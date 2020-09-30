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
    public partial class TaskGridPanel : UserControl, ITaskQueryEnable,IPagging
    {
        public List<TaskModel> taskModelAllList = new List<TaskModel>();
        private List<TaskModel> afterQueryTaskModelList = new List<TaskModel>();
        //private int _taskStateId;
        private int[] _taskStateArray;
        private TaskGridShownStyle _style;
        private static Dictionary<int, string> taskStateDic = new Dictionary<int, string>();

        public delegate void dgvRowCountHandler(int rouCount);
        public event dgvRowCountHandler OnDgvRowCountChange;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        static TaskGridPanel()
        {
            taskStateDic.Add((int)TaskStateEnum.Created, "未审批");
            taskStateDic.Add((int)TaskStateEnum.Passed, "已通过");
            taskStateDic.Add((int)TaskStateEnum.Rejected, "已驳回");
            taskStateDic.Add((int)TaskStateEnum.Running, "执行中");
            taskStateDic.Add((int)TaskStateEnum.Completed, "已完成");
            taskStateDic.Add((int)TaskStateEnum.Closed, "已关闭");
        }

        public TaskGridPanel()
        {
            InitializeComponent();
            dgv_taskList.AutoGenerateColumns = false;//保证columns显示顺序
            percent.BeforeCellPaint += Percent_BeforeCellPaint;
            pagingPanel.pagging = this;
        }

        private void Percent_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            if (dgv_taskList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                percent.Text = dgv_taskList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "%";
                percent.ToolTipText= "完成进度 "+dgv_taskList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "%";
            }
        }

        public void init(int[] taskStateArray, TaskGridShownStyle style)
        {
            this._taskStateArray = taskStateArray;
            this._style = style;
            var classList = CodeCache.getClass();
            var brandList = CodeCache.getBrand();
            var modelList = CodeCache.getModel();
            var taskList = TaskCache.getCache();
            var tasklifecycleList = TaskLifecycleCache.getCache();
            var taskModelMapList = TaskModelMapCache.getCache();
            taskModelAllList = (from task in taskList
                                from classCode in classList
                                from tasklifecycle in tasklifecycleList
                                    //from brandCode in brandList
                                    //from taskModelMap in taskModelMapList
                                //where (taskStateArray == (int)TaskStateEnum.Completed ? 
                                //    (task.taskState == taskStateArray || task.taskState == (int)TaskStateEnum.Rejected || task.taskState == (int)TaskStateEnum.Closed) 
                                //    : (task.taskState == taskStateArray))//如果是展示已完成任务，则需要附带已关闭、已驳回的任务
                                where taskStateArray.Contains(task.taskState)
                                && task.taskClass == classCode.id //&& taskModelMap.taskId == task.id && taskModelMap.brandId == brandCode.id
                                //todo 跟当前用户相关 
                                && task.id == tasklifecycle.taskId && tasklifecycle.taskState == 5001
                                && (task.taskExecutor.Contains(User.currentUser.name) || tasklifecycle.taskStateChangeExecutor == User.currentUser.name)//当前用户创建或测试人包含当前用户
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
        public void doQuery(TaskQueryItem _queryItem)
        {
            queryItem = _queryItem;
            afterQueryTaskModelList = (from taskModel in taskModelAllList
                                       where (queryItem.taskQueryName == string.Empty ? 1 == 1 : taskModel.taskName.Contains(queryItem.taskQueryName))
                                       && (queryItem.taskQueryBrand == string.Empty ? 1 == 1 : taskModel.taskBrandModelName.Contains(queryItem.taskQueryBrand))
                                       && (queryItem.taskState == 0 ? 1 == 1 : taskModel.taskStateId == queryItem.taskState)
                                       select taskModel).ToList();
            pagingPanel.setDetail(afterQueryTaskModelList.Count);
            var datasourcce = afterQueryTaskModelList.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
            dgv_taskList.DataSource = datasourcce;
            OnDgvRowCountChange(datasourcce.Count);//触发dgv行数变化事件，供父控件更新任务面板title
        }

        public void showStyle(TaskGridShownStyle style)
        {
            switch (style)
            {
                case TaskGridShownStyle.HideAll:
                    break;
                case TaskGridShownStyle.NewTask:
                    foreach (DataGridViewRow item in dgv_taskList.Rows)
                    {
                        if (item.Cells[7].Value.ToString() == "未审批" )
                        {
                            dgv_taskList.Columns["btn_open"].Visible = false;
                        }
                        else
                        {
                            //item.Cells[11].Visible = true;
                        }
                    }
                    dgv_taskList.Columns["btn_open"].Visible = true;
                    //dgv_taskList.Rows
                    //dgv_taskList.Columns["btn_open"].Visible = true;
                    dgv_taskList.ReadOnly = true;
                    break;
                case TaskGridShownStyle.RunningTask:
                    dgv_taskList.Columns["btn_open"].Visible = true;
                    break;
                case TaskGridShownStyle.DoneTask:
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
                        TaskCache.updateTaskState(taskId, (int)TaskStateEnum.Passed);
                        init(_taskStateArray, _style);
                    }
                    break;
                case "驳回":
                    TaskReject tr = new AviationSafetyExperiment.TaskReject();
                    if (tr.ShowDialog() == DialogResult.OK)
                    {
                        string remark = tr.rejectReason;
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, (int)TaskStateEnum.Rejected, remark);
                        init(_taskStateArray, _style);
                    }
                    break;
                case "打开任务":
                    var taskInfoId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                    TaskExecuteForm tef = new AviationSafetyExperiment.TaskExecuteForm(taskInfoId);
                    tef.init(_taskStateArray[0]);//用于打开任务时，取第一个任务状态
                    tef.ShowDialog(this);
                    break;
                case "完成":
                    if (MessageBoxEx.Show("确定任务完成？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, (int)TaskStateEnum.Completed);
                        init(_taskStateArray, _style);
                    }
                    break;
                case "关闭":
                    if (MessageBoxEx.Show("确定关闭任务？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var taskId = (int)dgv_taskList.Rows[e.RowIndex].Cells["taskId"].Value;
                        TaskCache.updateTaskState(taskId, (int)TaskStateEnum.Closed);
                        init(_taskStateArray, _style);
                    }
                    break;
                default:
                    break;
            }
        }

        private void dgv_taskList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //绘制行序号
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,dgv_taskList.RowHeadersWidth - 4,e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,(e.RowIndex + 1).ToString(),dgv_taskList.RowHeadersDefaultCellStyle.Font,
                   rectangle,dgv_taskList.RowHeadersDefaultCellStyle.ForeColor,TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        int pageSize = 10;//默认每页10条
        int pageNum = 1;//默认首页
        TaskQueryItem queryItem = new TaskQueryItem();
        public void doPagging(int pageNum, int pageSize)
        {
            this.pageSize = pageSize;
            this.pageNum = pageNum;
            doQuery(queryItem);
        }
    }
   
}
