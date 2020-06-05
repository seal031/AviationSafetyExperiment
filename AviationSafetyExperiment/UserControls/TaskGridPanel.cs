using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationSafetyExperiment.Model;
using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.DbLocalCache;
using DevComponents.DotNetBar;
using AviationSafetyExperiment.Db.Entity;
using DevComponents.DotNetBar.Controls;

namespace AviationSafetyExperiment.UserControls
{
    /// <summary>
    /// 用于显示任务列表
    /// </summary>
    public partial class TaskGridPanel : UserControl, ITaskQueryEnable
    {
        public List<TaskModel> taskModelList = new List<TaskModel>();
        private int _taskStateId;
        private TaskGridShownStyle _style;
        private static Dictionary<int, string> taskStateDic = new Dictionary<int, string>();

        static TaskGridPanel()
        {
            taskStateDic.Add(5001, "未审批");
            taskStateDic.Add(5002, "已通过");
            taskStateDic.Add(5003, "已驳回");
            taskStateDic.Add(5004, "执行中");
            taskStateDic.Add(5005, "已完成");
            taskStateDic.Add(5006, "已关闭");
        }

        public TaskGridPanel()
        {
            InitializeComponent();
            percent.TextVisible = false;
            percent.BeforeCellPaint += Percent_BeforeCellPaint;
        }

        private void Percent_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            //DataGridViewProgressBarXColumn pbc =sender as DataGridViewProgressBarXColumn;
            //pbc.Text = dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value.ToString();
        }

        public void init(int taskStateId,TaskGridShownStyle style)
        {
            this._taskStateId = taskStateId;
            this._style = style;
            var classList = CodeCache.getClass();
            var brandList = CodeCache.getBrand();
            var modelList = CodeCache.getModel();
            var taskList = TaskCache.getCache();
            var taskModelMapList = TaskModelMapCache.getCache();
            taskModelList = (from task in taskList
                             from classCode in classList
                                 //from brandCode in brandList
                                 //from taskModelMap in taskModelMapList
                             where task.taskState == taskStateId && task.taskClass == classCode.id //&& taskModelMap.taskId == task.id && taskModelMap.brandId == brandCode.id
                             select new TaskModel
                             {
                                 taskId = task.id,
                                 taskName = task.taskName,
                                 taskStateId = task.taskState,
                                 taskStateName = taskStateDic[task.taskState],
                                 taskBrandModelName = string.Join(Environment.NewLine, from brandCode in brandList
                                                                                       from modelCode in modelList
                                                                                       from taskModelMap in taskModelMapList
                                                                                       where taskModelMap.taskId == task.id && taskModelMap.brandId == brandCode.id && taskModelMap.ModelId == modelCode.id
                                                                                       select brandCode.codeName + "    " + modelCode.codeName),
                                 taskClassName = classCode.codeName,
                                 taskStartTime = task.createTime,
                                 taskCode = task.taskCode,
                                 percent = task.percent
                             }).ToList();
            doQuery(new TaskQueryItem());
            showStyle(style);
        }
        public void doQuery(TaskQueryItem queryItem)
        {
            var dgvSource = (from taskModel in taskModelList
                            where (queryItem.taskQueryName == string.Empty ? 1 == 1 : taskModel.taskName.Contains(queryItem.taskQueryName))
                            && (queryItem.taskQueryBrand == string.Empty ? 1 == 1 : taskModel.taskBrandModelName.Contains(queryItem.taskQueryBrand))
                            select taskModel).ToList();
            dgv_taskList.DataSource = dgvSource;
        }

        public void showStyle(TaskGridShownStyle style)
        {
            switch (style)
            {
                case TaskGridShownStyle.HideAll:
                    break;
                case TaskGridShownStyle.NewTask:
                    if (_taskStateId == 5001)//新建任务对于审批人员来说是新任务，所以可以看到通过、驳回
                    {
                        dgv_taskList.Columns["btn_pass"].Visible = true;
                        dgv_taskList.Columns["btn_reject"].Visible = true;
                    }
                    if (_taskStateId == 5002)//审批通过任务对于测试人员来说是新任务，所以可以看到打开任务
                    {
                        dgv_taskList.Columns["btn_open"].Visible = true;
                    }
                    break;
                case TaskGridShownStyle.RunningTask:
                    dgv_taskList.Columns["btn_done"].Visible = true;
                    dgv_taskList.Columns["btn_open"].Visible = true;
                    break;
                case TaskGridShownStyle.DoneTask:
                    dgv_taskList.Columns["btn_close"].Visible = true;
                    break;
                case TaskGridShownStyle.CloseTask:
                    break;
                default:
                    break;
            }
        }

        //双击打开任务详情
        private void dgv_taskList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var taskInfoId = dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
            TaskDetial detialForm = new AviationSafetyExperiment.TaskDetial((int)taskInfoId);
            detialForm.init();
            detialForm.ShowDialog(this);
        }

        private void dgv_taskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgv_taskList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
            {
                case "通过":
                    if (MessageBoxEx.Show("确定审批通过？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, 5002);
                        init(_taskStateId, _style);
                    }
                    break;
                case "驳回":
                    TaskReject tr = new AviationSafetyExperiment.TaskReject();
                    if (tr.ShowDialog() == DialogResult.OK)
                    {
                        string remark = tr.rejectReason;
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, 5003, remark);
                        init(_taskStateId, _style);
                    }
                    break;
                case "打开任务":
                    var taskInfoId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                    TaskExecuteForm tef = new AviationSafetyExperiment.TaskExecuteForm(taskInfoId);
                    tef.init();
                    tef.ShowDialog(this);
                    break;
                case "完成":
                    if (MessageBoxEx.Show("确定任务完成？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, 5005);
                        init(_taskStateId, _style);
                    }
                    break;
                case "关闭":
                    if (MessageBoxEx.Show("确定关闭任务？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, 5006);
                        init(_taskStateId, _style);
                    }
                    break;
                default: 
                    break;
            }
        }

        private void dgv_taskList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dgv_taskList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 13&&e.RowIndex>=0)
            {
                var processCell = dgv_taskList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewProgressBarXCell;
                processCell.ToolTipText = processCell.Value.ToString()+"%";
            }
        }
    }

    public enum TaskGridShownStyle
    {
        HideAll,
        NewTask,
        RunningTask,
        DoneTask,
        CloseTask
    }
}
