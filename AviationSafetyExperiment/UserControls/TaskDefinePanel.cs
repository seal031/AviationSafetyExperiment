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
using AviationSafetyExperiment.DbLocalCache;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskDefinePanel : UserControl
    {
        private int taskType = -1;

        public List<int> indicatorIdList;

        public TaskDefinePanel()
        {
            InitializeComponent();
        }

        public void init()
        {
            cbb_taskClass.DisplayMember = "codeName";
            cbb_taskClass.ValueMember = "id";
            cbb_taskClass.DataSource = CodeCache.getClass();
        }

        private void btn_createTask_Click(object sender, EventArgs e)
        {
            Tb_taskInfo task = new Db.Entity.Tb_taskInfo();
            task.percent = 0;
            task.taskClass = (int)cbb_taskClass.SelectedValue;
            task.taskCode = txt_taskCode.Text.Trim();
            task.taskExecutor = txt_taskExecutor.Text.Trim();
            task.taskName = txt_taskName.Text.Trim();
            task.taskType = taskType;
            task.taskState=
        }
    }
}
