using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using AviationSafetyExperiment.Model;
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
        private int _taskStateId;
        public int taskInfoId;
        private int currentRound = 1, maxRound = 1;
        public TaskExecuteForm(int taskInfoId)
        {
            InitializeComponent();
            this.taskInfoId = taskInfoId;
        }

        public void init(int taskStateId)
        {
            this._taskStateId = taskStateId;
            if (taskStateId == (int)TaskStateEnum.Created)//如果是新建任务，则显示通过、驳回
            {
                btn_done.Visible = false;
                btn_save.Visible = false;
                btn_close.Visible = false;
                trp.init(taskInfoId, true, currentRound);//此时只读
                ribbonBar_taskRound.Visible = false;//不显示轮次操作
            }
            else//如果是处理中的任务，显示保存、完成、关闭
            {
                btn_pass.Visible = false;
                btn_reject.Visible = false;
                trp.init(taskInfoId, false, currentRound);
            }
            bindTaskRound();
            tdbip.init(taskInfoId);
            checkAndSignFirstOpen();
        }
        /// <summary>
        /// 绑定轮次显示
        /// </summary>
        private void bindTaskRound()
        {
            var orderRoundList = TaskResultCache.getCache().Where(r => r.taskId == taskInfoId).GroupBy(r => r.taskRound).OrderBy(r => r.Key).ToList();
            if (orderRoundList.Count == 0)
            {
                currentRound = 1;
                maxRound = 1;
                ButtonItem btn_round = new ButtonItem();
                btn_round.ShowSubItems = false;
                btn_round.SubItemsExpandWidth = 14;
                btn_round.Text = "1";
                btn_round.Click += new System.EventHandler(btn_round_Click);
                this.ribbonBar_taskRound.Items.Add(btn_round);
            }
            else
            {
                foreach (var tr in orderRoundList)
                {
                    int round = tr.Key;
                    ButtonItem btn_round = new ButtonItem();
                    btn_round.ShowSubItems = false;
                    btn_round.SubItemsExpandWidth = 14;
                    btn_round.Text = round.ToString();
                    btn_round.Click += new System.EventHandler(btn_round_Click);
                    this.ribbonBar_taskRound.Items.Add(btn_round);
                }
                maxRound = orderRoundList.Count;
            }
        }

        /// <summary>
        /// 检查任务是否第一次打开。如是，则更新任务状态为“已开始”，同时添加任务生命周期
        /// </summary>
        private void checkAndSignFirstOpen()
        {
            var isPassed = TaskLifecycleCache.getCache().FirstOrDefault(l => l.taskId == taskInfoId && l.taskState == (int)TaskStateEnum.Passed);
            var isOpened = TaskLifecycleCache.getCache().FirstOrDefault(l => l.taskId == taskInfoId && l.taskState == (int)TaskStateEnum.Running);
            if (isPassed != null && isOpened == null)//如果审批通过，但从未打开过
            {
                TaskCache.updateTaskState(taskInfoId, (int)TaskStateEnum.Running);
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
                    dr.Cells["taskResult"].Selected = true;
                    return false;
                }
                else if (dr.Cells["taskResult"].Value.ToString() == "0")
                {
                    dr.Cells["taskResult"].Selected = true;
                    return false;
                }
                else
                {
                    if (dr.Cells["taskRecord"].Value == null)
                    {
                        dr.Cells["taskRecord"].Selected = true;
                        return false;
                    }
                    else if (dr.Cells["taskRecord"].Value.ToString() == string.Empty)
                    {
                        dr.Cells["taskRecord"].Selected = true;
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
                    oldRound = (int)(dr.Cells["taskStep"].Value);
                }
                //如果修改过测试结果，或是测试结果内有内容（无论是否本次输入），都保存
                if (dr.Cells["taskResult"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["taskRecord"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["taskRemark"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["attachmentCount"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["taskResult"].Value.ToString() != "0"
                    || dr.Cells["taskRecord"].Value.ToString() != string.Empty
                    || dr.Cells["taskRemark"].Value.ToString() != string.Empty
                    || dr.Cells["attachment"].Value.ToString() != string.Empty)
                {
                    Tb_taskResult result = new Tb_taskResult();
                    result.indicatorId = (int)dr.Cells["indicatorId"].Value;
                    result.modelId = (int)dr.Cells["modelId"].Value;
                    result.taskDateTime = DateTime.Now;
                    result.taskExecutor = User.currentUser.name;
                    result.taskId = taskInfoId;
                    result.taskRecord = dr.Cells["taskRecord"].Value.ToString();
                    result.taskRemark = dr.Cells["taskRemark"].Value.ToString();
                    result.taskResult = (int)dr.Cells["taskResult"].Value;
                    result.attachment = dr.Cells["attachment"].Value.ToString();
                    result.supplement = dr.Cells["supplement"].Value == null ? "" : dr.Cells["supplement"].Value.ToString();
                    result.taskStep = oldRound + 1;
                    resultList.Add(result);
                }
            }
            if (resultList.Count > 0)
            {
                TaskResultCache.addCache(resultList);//添加测试记录
                var taskInfo = TaskCache.getCacheById(taskInfoId);//更新任务进度字段
                var taskResultMainCount = trp.getAllResultModelCount();
                taskInfo.percent = resultList.Count*100 / taskResultMainCount;
                TaskCache.addCache(taskInfo);
                //刷新单元格背景色为白色
                foreach (DataGridViewRow dr in trp.dgv.Rows)
                {
                    dr.Cells["taskResult"].Style.BackColor = Color.White;
                    dr.Cells["taskRecord"].Style.BackColor = Color.White;
                    dr.Cells["taskRemark"].Style.BackColor = Color.White;
                    dr.Cells["attachmentCount"].Style.BackColor = Color.White;
                }
                MainFormAdapter.reloadTaskMainPanel();
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
                TaskCache.updateTaskState(taskInfoId, (int)TaskStateEnum.Completed);
                MainFormAdapter.reloadTaskMainPanel();
                MessageBoxEx.Show("任务已设置为【完成】状态");
                this.Close();
            }
        }

        private void ben_close_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("您确定要关闭此测试任务？"+Environment.NewLine+"任务关闭后将无法对剩余的指标进行测试。","操作警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                TaskCache.updateTaskState(taskInfoId, (int)TaskStateEnum.Closed);
                MainFormAdapter.reloadTaskMainPanel();
                this.Close();
            }
        }

        private void btn_pass_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("确定审批通过？", "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                TaskCache.updateTaskState(taskInfoId, (int)TaskStateEnum.Passed);
                MainFormAdapter.reloadTaskApproval();
                this.Close();
            }
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            TaskReject tr = new AviationSafetyExperiment.TaskReject();
            if (tr.ShowDialog() == DialogResult.OK)
            {
                string remark = tr.rejectReason;
                TaskCache.updateTaskState(taskInfoId, (int)TaskStateEnum.Rejected, remark);
                MainFormAdapter.reloadTaskApproval();
                this.Close();
            }
        }

        private void btn_newRound_Click(object sender, EventArgs e)
        {
            if (checkCanDone() == false)
            {
                MessageBoxEx.Show("您尚有未填写的指标测试结果，无法开始下一轮测试。", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TaskNewRoundDefine tnrd = new TaskNewRoundDefine(taskInfoId, maxRound + 1);
                tnrd.ShowDialog(this);
                tnrd.init();
            }
        }

        private void btn_round_Click(object sender, EventArgs e)
        {
            var btn_round = sender as ButtonItem;
            int round;
            if (int.TryParse(btn_round.Text, out round))
            {
                if (trpIsEdited())
                {
                    MessageBoxEx.Show("当前轮次还有尚未保存的修改，请先保存任务，再进行轮次切换。", "操作风险", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (round == currentRound)
                {
                    trp.init(taskInfoId, false, round);//如果选中了当前轮次，可以编辑
                }
                else
                {
                    trp.init(taskInfoId, true, round);//如果选中了之前的轮次，只读
                }
            }
            else
            {
                MessageBoxEx.Show("要查看的轮次无效。", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool trpIsEdited()
        {
            foreach (DataGridViewRow dr in trp.dgv.Rows)
            {
                if (dr.Cells["taskResult"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["taskRecord"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["taskRemark"].Style.BackColor == Color.LightSeaGreen
                    || dr.Cells["attachmentCount"].Style.BackColor == Color.LightSeaGreen)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
