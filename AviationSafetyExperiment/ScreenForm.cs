using AviationSafetyExperiment.Model;
using AviationSafetyExperiment.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]//COM+组件可见
    public partial class ScreenForm : DevComponents.DotNetBar.Office2007Form
    {
        string SODBmainpage = string.Empty;
        const string cookieKey = "HA_LINK_LOGIN_INFO";

        public ScreenForm()
        {
            InitializeComponent();
        }

        private void ScreenForm_Shown(object sender, EventArgs e)
        {
            SODBmainpage = ConfigWorker.GetConfigValue("SODBmainpage");
            wb.ObjectForScripting = this;
            CookieWorker.SetCookie(SODBmainpage, cookieKey, User.currentUser.cookieValue);
            wb.Navigate(SODBmainpage);
        }

        private void ScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            wb.Dispose();
            wb = null;
            GC.Collect();
        }
    }

    public class CookieWorker
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);
        public static bool SetCookie(string url, string cookieKey, string cookieValue)
        {
            return InternetSetCookie(url, cookieKey, cookieValue);
        }
    }
}
