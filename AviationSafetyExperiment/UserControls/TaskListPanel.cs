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
    public partial class TaskListPanel : UserControl
    {
        public TaskListPanel()
        {
            InitializeComponent();
        }

        public void init(int taskStateId,TaskGridShownStyle style)
        {
            taskGridPanel.init(taskStateId, style);
            taskQueryPanel.taskQuery = taskGridPanel;
        }
    }
}
