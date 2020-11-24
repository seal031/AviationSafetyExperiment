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
using AviationSafetyExperiment.Utils;
using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.Db.DAO;

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
                ScreenForm screenForm = new ScreenForm();
                screenForm.Show();
                MainForm mainForm = new AviationSafetyExperiment.MainForm();
                MainFormAdapter.setMainForm(mainForm);
                mainForm.Show();
                this.Hide();
            }
        }

        private bool login()
        {
            var tempList = BaseAdapter.getAll<Tb_code>();
            if (tempList.Count() == 0)
            {
                return false;
            }
            //HttpWorker.getUser(txt_username.Text.Trim());//模拟用户获取 
            bool loginResult = HttpWorker.login(txt_username.Text.Trim(), txt_password.Text.Trim());
            bool getUserListResult = HttpWorker.getUserList();
            return loginResult && getUserListResult;
        }
    }
}
