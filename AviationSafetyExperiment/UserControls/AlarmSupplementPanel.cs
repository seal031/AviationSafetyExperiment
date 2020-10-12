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
    public partial class AlarmSupplementPanel : UserControl
    {
        public AlarmSupplementPanel()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {
            DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn control = (DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn)dgv.Columns["classify"];
            List<string> cla = new List<string>();
            //cla.Add("正常");
            cla.Add("补报");
            cla.Add("漏报");
            control.DataSource = cla;
        }
    }
}
