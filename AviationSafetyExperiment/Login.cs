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
                MainFormAdapter.setMainForm(mainForm);
                mainForm.Show();
                this.Hide();
            }
        }

        private bool login()
        {
            UserInfo.userName = "齐可新";
            UserInfo.indentity = UserIdentityEnum.Test_Officers;
            //UserInfo.indentity = UserIdentityEnum.Approving_Officers;
            return true;
        }
    }
}
