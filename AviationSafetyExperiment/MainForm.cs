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
    public partial class MainForm : DevComponents.DotNetBar.Office2007Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void qatCustomizePanel1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            showHome();
        }

        #region 水平菜单点击事件
        private void btn_item_home_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void btn_item_taskManager_Click(object sender, EventArgs e)
        {
            showTaskProcess();
        }

        private void btn_item_alarm_Click(object sender, EventArgs e)
        {

        }

        private void btn_brandSet_Click(object sender, EventArgs e)
        {
            BrandManage bm = new AviationSafetyExperiment.BrandManage();
            bm.ShowDialog(this);
        }

        private void btn_indicatorSet_Click(object sender, EventArgs e)
        {
            IndicatorManage im = new IndicatorManage();
            im.ShowDialog(this);
        }

        private void btn_taskReport_Click(object sender, EventArgs e)
        {
            TaskReport tr = new TaskReport();
            tr.ShowDialog(this);
        }
        #endregion

        private void showHome()
        {
            expandablePanel.TitleText = "测试任务统计";
            expandablePanel.MaximumSize = new System.Drawing.Size(300, 0);
            expandablePanel.Size= new System.Drawing.Size(300, 0);
            slidePanelMain.Controls.Clear();
            addControl(slidePanelMain, taskMainPanel);
            removeControl(expandablePanel, taskProcessSlidePanel);
            addControl(expandablePanel, taskChartSlidePanel);
            //expandablePanel.Refresh();
            expandablePanel.Expanded = true;
            //panelExMain.Refresh();
        }
        private void showTaskProcess()
        {
            expandablePanel.TitleText = "测试任务操作";
            expandablePanel.MaximumSize = new System.Drawing.Size(150, 0);
            expandablePanel.Size = new System.Drawing.Size(150, 0);
            removeControl(expandablePanel, taskChartSlidePanel);
            addControl(expandablePanel, taskProcessSlidePanel);
            slidePanelMain.Controls.Clear();
            //expandablePanel.Refresh();
            expandablePanel.Expanded = true;
            //panelExMain.Refresh();
        }


        private void addControl(Control parent, Control son)
        {
            if (!parent.Controls.Contains(son)) { parent.Controls.Add(son); }
        }
        private void removeControl(Control parent, Control son)
        {
            if (parent.Controls.Contains(son)) { parent.Controls.Remove(son); }
        }
    }
}
