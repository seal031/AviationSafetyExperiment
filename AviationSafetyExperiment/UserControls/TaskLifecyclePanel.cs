using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationSafetyExperiment.DbLocalCache;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskLifecyclePanel : UserControl
    {
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskLifecyclePanel()
        {
            InitializeComponent();
        }

        public void init(int taskInfoId)
        {
            var taskLifeList = TaskLifecycleCache.getCache().Where(t => t.taskId == taskInfoId).OrderBy(t=>t.taskState).ToList() ;
            var taskStateList = CodeCache.getState();
            var tempList = from life in taskLifeList
                           from state in taskStateList
                           where life.taskState == state.id
                           select new
                           {
                               life,
                               state
                           };
            List<String> textList = new List<string>();
            foreach (var taskLife in tempList)
            {
                textList.Add(taskLife.life.taskStateDateTime+"                  状态：" + taskLife.state.codeName + "                  操作人：" + taskLife.life.taskStateChangeExecutor + "                  备注：" + taskLife.life.remark);
            }
            lbl_taskLifecycle.Text = string.Join(Environment.NewLine, textList);
        }
    }
}
