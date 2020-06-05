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
    public partial class TaskReject : DevComponents.DotNetBar.Office2007Form
    {
        public string rejectReason;

        public TaskReject()
        {
            InitializeComponent();
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            rejectReason = txt_reason.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
