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
using AviationSafetyExperiment.UserControls;

namespace AviationSafetyExperiment
{
    public partial class MainForm : DevComponents.DotNetBar.Office2007Form
    {
        TaskDefinePanel taskDefinePanel;
        TaskListPanel taskApprovePanel;
        TaskListPanel taskProcessPanel;
        TaskListPanel taskExecutePanel;

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
            bindSlideBarButtonClickEvent();//首次加载窗体时绑定侧边栏按钮事件
        }

        private void bindSlideBarButtonClickEvent()
        {
            taskProcessSlidePanel.btn_taskApprove.Click += Btn_taskApprove_Click;
            taskProcessSlidePanel.btn_taskDefine.Click += Btn_taskDefine_Click;
            taskProcessSlidePanel.btn_taskExecute.Click += Btn_taskExecute_Click;
            taskProcessSlidePanel.btn_taskProcess.Click += Btn_taskProcess_Click;
        }

        #region 水平菜单点击事件
        private void btn_item_home_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void btn_item_taskManager_Click(object sender, EventArgs e)
        {
            showTaskSidebar();
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
            //todo 显示测试报告列表，或也可用已完成任务列表替代
        }
        #endregion

        #region 侧边栏点击事件
        private void Btn_taskProcess_Click(object sender, EventArgs e)
        {
            showTaskProcess();
        }

        private void Btn_taskExecute_Click(object sender, EventArgs e)
        {
            showTaskExecute();
        }

        private void Btn_taskDefine_Click(object sender, EventArgs e)
        {
            showTaskDefine();
        }

        private void Btn_taskApprove_Click(object sender, EventArgs e)
        {
            showTaskApprove();
        }
        #endregion

        /// <summary>
        /// 显示主页
        /// </summary>
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
            taskMainPanel.init();
            taskMainPanel.BringToFront();
        }
        /// <summary>
        /// 显示任务处理侧边
        /// </summary>
        private void showTaskSidebar()
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
        /// <summary>
        /// 显示任务定义
        /// </summary>
        private void showTaskDefine()
        {
            if (taskDefinePanel == null)
            {
                taskDefinePanel = new TaskDefinePanel();
                taskDefinePanel.Dock = DockStyle.Fill;
            }
            addControl(panelExMain, taskDefinePanel);
            taskDefinePanel.BringToFront();
            taskDefinePanel.init();
        }
        /// <summary>
        /// 显示任务审核
        /// </summary>
        private void showTaskApprove()
        {
            if (taskApprovePanel == null)
            {
                taskApprovePanel = new TaskListPanel();
                taskApprovePanel.Dock = DockStyle.Fill;
            }
            addControl(panelExMain, taskApprovePanel);
            taskApprovePanel.BringToFront();
            taskApprovePanel.init(5001,TaskGridShownStyle.HideAll);
        }
        /// <summary>
        /// 显示任务过程管理
        /// </summary>
        private void showTaskProcess()
        {
            if (taskProcessPanel == null)
            {
                taskProcessPanel = new TaskListPanel();
                taskProcessPanel.Dock = DockStyle.Fill;
            }
            addControl(panelExMain, taskProcessPanel);
            taskProcessPanel.BringToFront();
            taskProcessPanel.init(5004, TaskGridShownStyle.HideAll);
        }
        /// <summary>
        /// 显示任务执行管理
        /// </summary>
        private void showTaskExecute()
        {
            if (taskExecutePanel == null)
            {
                taskExecutePanel = new TaskListPanel();
                taskExecutePanel.Dock = DockStyle.Fill;
            }
            addControl(panelExMain, taskExecutePanel);
            taskExecutePanel.BringToFront();
            taskExecutePanel.init(5004, TaskGridShownStyle.HideAll);
        }

        private void addControl(Control parent, Control son)
        {
            if (!parent.Controls.Contains(son)) { parent.Controls.Add(son); }
        }
        private void removeControl(Control parent, Control son)
        {
            if (parent.Controls.Contains(son)) { parent.Controls.Remove(son); }
        }

        #region 供其他组件调用
        public void reloadTaskMainPanel()
        {
            taskMainPanel.init();
        }
        #endregion
    }
}
