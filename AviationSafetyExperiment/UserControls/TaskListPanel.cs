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

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskListPanel : UserControl
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
        public TaskListPanel()
        {
            InitializeComponent();
        }

        public void init(int[] taskStateIdArray,TaskGridShownStyle style)
        {
            taskGridPanel.OnDgvRowCountChange += TaskGridPanel_OnDgvRowCountChange;
            taskGridPanel.init(taskStateIdArray, style);
            taskQueryPanel.setTaskQuery(taskGridPanel);
        }

        private void TaskGridPanel_OnDgvRowCountChange(int rouCount)
        {
            
        }
    }
}
