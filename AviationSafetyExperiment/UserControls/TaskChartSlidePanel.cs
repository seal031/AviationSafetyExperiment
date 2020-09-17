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
    public partial class TaskChartSlidePanel : UserControl
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
        public TaskChartSlidePanel()
        {
            InitializeComponent();
        }
    }
}
