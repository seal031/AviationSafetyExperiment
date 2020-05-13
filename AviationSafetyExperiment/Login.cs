using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents;

namespace AviationSafetyExperiment
{
    public partial class Login : DevComponents.DotNetBar.Office2007Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login())
            {
                MainForm mainForm = new AviationSafetyExperiment.MainForm();
                mainForm.Show();
                this.Hide();
            }
        }

        private bool login()
        {
            return true;
        }
    }
}
