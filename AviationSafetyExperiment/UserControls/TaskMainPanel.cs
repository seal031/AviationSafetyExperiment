using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskMainPanel : UserControl
    {
        public TaskMainPanel()
        {
            InitializeComponent();
        }

        private void Tgp_reload()
        {
            init();
        }

        public void init()
        {
            tgp_new.init(5001, TaskGridShownStyle.NewTask);//todo 根据权限区分。审批者可以看到的是5001新建的；测试人员可以看到的是5002已通过的
            tgp_running.init(5004,TaskGridShownStyle.RunningTask);//已开始
            tgp_done.init(5005,TaskGridShownStyle.DoneTask);//已完成
        }

        private void btni_new_more_Click(object sender, EventArgs e)
        {

        }

        private void btni_running_more_Click(object sender, EventArgs e)
        {

        }

        private void btni_done_more_Click(object sender, EventArgs e)
        {

        }

        private void btni_report_more_Click(object sender, EventArgs e)
        {

        }
    }
}
