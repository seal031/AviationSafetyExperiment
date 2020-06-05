using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    public partial class TaskExecuteForm : Form
    {
        public int taskInfoId;
        public TaskExecuteForm(int taskInfoId)
        {
            InitializeComponent();
            this.taskInfoId = taskInfoId;
        }

        public void init()
        {
            tdbip.init(taskInfoId);
            trp.init(taskInfoId);
            checkAndSignFirstOpen();
        }
        /// <summary>
        /// 检查任务是否第一次打开。如是，则更新任务状态为“已开始”，同时添加任务生命周期
        /// </summary>
        private void checkAndSignFirstOpen()
        {
            var isPassed = TaskLifecycleCache.getCache().FirstOrDefault(l => l.taskId == taskInfoId && l.taskState == 5002);
            var isOpened = TaskLifecycleCache.getCache().FirstOrDefault(l => l.taskId == taskInfoId && l.taskState == 5004);
            if (isPassed != null && isOpened == null)//如果审批通过，但从未打开过
            {
                TaskCache.updateTaskState(taskInfoId, 5004);
            }
        }
        /// <summary>
        /// 检查是否可以执行任务完成操作（是否所有指标都填写了测试结果）
        /// </summary>
        /// <returns></returns>
        private bool checkCanDone()
        {
            foreach (DataGridViewRow dr in trp.dgv.Rows)
            {
                if (dr.Cells["taskResult"].Value == null)
                {
                    return false;
                }
                else if (dr.Cells["taskResult"].Value.ToString() == "0")
                {
                    return false;
                }
                else
                {
                    if (dr.Cells["taskRecord"].Value == null)
                    {
                        return false;
                    }
                    else if (dr.Cells["taskRecord"].Value.ToString() == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            List<Tb_taskResult> resultList = new List<Db.Entity.Tb_taskResult>();
            int oldRound = -1;
            foreach (DataGridViewRow dr in trp.dgv.Rows)
            {
                if (oldRound == -1)
                {
                    oldRound = (int)(dr.Cells["taskRound"].Value);
                }
                //如果修改过测试结果，或是测试结果内有内容（无论是否本次输入），都保存
                if (dr.Cells["taskResult"].Style.BackColor == Color.LightSeaGreen 
                    || dr.Cells["taskRecord"].Style.BackColor == Color.LightSeaGreen 
                    || dr.Cells["taskRemark"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["taskResult"].Value.ToString()!="0"
                    || dr.Cells["taskRecord"].Value.ToString()!=string.Empty
                    || dr.Cells["taskRemark"].Value.ToString()!=string.Empty)
                {
                    Tb_taskResult result = new Tb_taskResult();
                    result.indicatorId = (int)dr.Cells["indicatorId"].Value;
                    result.modelId = (int)dr.Cells["modelId"].Value;
                    result.taskDateTime = DateTime.Now;
                    result.taskExecutor = UserInfo.userName;
                    result.taskId = taskInfoId;
                    result.taskRecord = dr.Cells["taskRecord"].Value.ToString();
                    result.taskRemark = dr.Cells["taskRemark"].Value.ToString();
                    result.taskResult = (int)dr.Cells["taskResult"].Value;
                    result.taskRound = oldRound+1;
                    resultList.Add(result);
                }
            }
            if (resultList.Count > 0)
            {
                TaskResultCache.addCache(resultList);//添加测试记录
                var taskInfo = TaskCache.getCacheById(taskInfoId);//更新任务进度字段
                var taskResultMainCount = trp.dgv.Rows.Count;
                taskInfo.percent = resultList.Count*100 / taskResultMainCount;
                TaskCache.addCache(taskInfo);
                //刷新单元格背景色为白色
                foreach (DataGridViewRow dr in trp.dgv.Rows)
                {
                    dr.Cells["taskResult"].Style.BackColor = Color.White;
                    dr.Cells["taskRecord"].Style.BackColor = Color.White;
                    dr.Cells["taskRemark"].Style.BackColor = Color.White;
                }
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (checkCanDone() == false)
            {
                MessageBoxEx.Show("您尚有未填写的指标测试结果，无法完成任务。", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TaskCache.updateTaskState(taskInfoId, 5005);
                MainFormAdapter.reloadTaskMainPanel();
            }
        }

        private void ben_close_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("您确定要关闭此测试任务？"+Environment.NewLine+"任务关闭后将无法对剩余的指标进行测试。","操作警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TaskCache.updateTaskState(taskInfoId, 5006);
                MainFormAdapter.reloadTaskMainPanel();
            }
        }
    }
}
