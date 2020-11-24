using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationSafetyExperiment.Db.Entity;
using DevComponents.DotNetBar;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskMainPanel : UserControl
    {
        List<ExpandablePanel> expandablePanelList = new List<ExpandablePanel>();
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskMainPanel()
        {
            InitializeComponent();
            //关联查询条件和任务列表
            tqp.setTaskQuery(tgp_done);
            tqp.setTaskQuery(tgp_new);
            tqp.setTaskQuery(tgp_running);
            expandablePanelList.Add(expandablePanel_done);
            expandablePanelList.Add(expandablePanel_new);
            expandablePanelList.Add(expandablePanel_running);
            expandablePanelList.Add(expandablePanel_report);
            tgp_done.OnDgvRowCountChange += Tgp_done_OnDgvRowCountChange;
            tgp_new.OnDgvRowCountChange += Tgp_new_OnDgvRowCountChange;
            tgp_running.OnDgvRowCountChange += Tgp_running_OnDgvRowCountChange;
        }

        private void Tgp_running_OnDgvRowCountChange(int rouCount)
        {
            expandablePanel_running.TitleText = "处理中任务(" + rouCount + ")";
        }

        private void Tgp_new_OnDgvRowCountChange(int rouCount)
        {
            expandablePanel_new.TitleText = "待处理任务(" + rouCount + ")";
        }

        private void Tgp_done_OnDgvRowCountChange(int rouCount)
        {
            expandablePanel_done.TitleText = "已完成任务(" + rouCount + ")";
        }

        public void init()
        {
            //Task.Run(() =>
            //{
            //    tgp_new.init(new int[] { (int)TaskStateEnum.Passed, (int)TaskStateEnum.Created }, TaskGridShownStyle.NewTask);//已创建、已审批
            //    });
            //Task.Run(() =>
            //{
            //    tgp_running.init(new int[] { (int)TaskStateEnum.Running }, TaskGridShownStyle.RunningTask);//已开始
            //});
            //Task.Run(() =>
            //{
            //    tgp_done.init(new int[] { (int)TaskStateEnum.Completed, (int)TaskStateEnum.Closed, (int)TaskStateEnum.Rejected }, TaskGridShownStyle.DoneTask);//已完成、驳回、关闭
            //});

            tgp_new.init(new int[] { (int)TaskStateEnum.Passed, (int)TaskStateEnum.Created }, TaskGridShownStyle.NewTask);//已创建、已审批
            tgp_running.init(new int[] { (int)TaskStateEnum.Running }, TaskGridShownStyle.RunningTask);//已开始
            tgp_done.init(new int[] { (int)TaskStateEnum.Completed, (int)TaskStateEnum.Closed, (int)TaskStateEnum.Rejected }, TaskGridShownStyle.DoneTask);//已完成、驳回、关闭
        }

        private void expandablePanel_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            if (e.NewExpandedValue == false)
            {

            }
            else
            {
                var expandablePanel = sender as ExpandablePanel;
                foreach (ExpandablePanel ep in expandablePanelList)
                {
                    if (ep != expandablePanel)
                    {
                        ep.Expanded = false;
                    }
                }
            }
        }
    }
}
