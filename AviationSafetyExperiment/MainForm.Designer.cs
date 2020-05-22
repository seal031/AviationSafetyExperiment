namespace AviationSafetyExperiment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btn_item_home = new DevComponents.DotNetBar.ButtonItem();
            this.btn_item_taskManager = new DevComponents.DotNetBar.ButtonItem();
            this.btn_item_alarm = new DevComponents.DotNetBar.ButtonItem();
            this.btn_brandSet = new DevComponents.DotNetBar.ButtonItem();
            this.btn_indicatorSet = new DevComponents.DotNetBar.ButtonItem();
            this.btn_taskReport = new DevComponents.DotNetBar.ButtonItem();
            this.panelExMain = new DevComponents.DotNetBar.PanelEx();
            this.slidePanelMain = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.expandablePanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.taskMainPanel = new AviationSafetyExperiment.UserControls.TaskMainPanel();
            this.taskProcessSlidePanel = new AviationSafetyExperiment.UserControls.TaskProcessSlidePanel();
            this.taskChartSlidePanel = new AviationSafetyExperiment.UserControls.TaskChartSlidePanel();
            this.panelEx1.SuspendLayout();
            this.panelExMain.SuspendLayout();
            this.expandablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1259, 79);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(883, 53);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(338, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "欢迎您，xxx， 2020年5月8日，星期六";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(840, 79);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            this.panelEx2.Text = "panelEx2";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_item_home,
            this.btn_item_taskManager,
            this.btn_item_alarm,
            this.btn_brandSet,
            this.btn_indicatorSet,
            this.btn_taskReport});
            this.ribbonBar1.ItemSpacing = 5;
            this.ribbonBar1.Location = new System.Drawing.Point(0, 79);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1259, 30);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 1;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.TitleVisible = false;
            // 
            // btn_item_home
            // 
            this.btn_item_home.Name = "btn_item_home";
            this.btn_item_home.SubItemsExpandWidth = 14;
            this.btn_item_home.Text = "首页";
            this.btn_item_home.Click += new System.EventHandler(this.btn_item_home_Click);
            // 
            // btn_item_taskManager
            // 
            this.btn_item_taskManager.Name = "btn_item_taskManager";
            this.btn_item_taskManager.SubItemsExpandWidth = 14;
            this.btn_item_taskManager.Text = "测试任务管理";
            this.btn_item_taskManager.Click += new System.EventHandler(this.btn_item_taskManager_Click);
            // 
            // btn_item_alarm
            // 
            this.btn_item_alarm.Name = "btn_item_alarm";
            this.btn_item_alarm.SubItemsExpandWidth = 14;
            this.btn_item_alarm.Text = "报警联动";
            this.btn_item_alarm.Click += new System.EventHandler(this.btn_item_alarm_Click);
            // 
            // btn_brandSet
            // 
            this.btn_brandSet.Name = "btn_brandSet";
            this.btn_brandSet.SubItemsExpandWidth = 14;
            this.btn_brandSet.Text = "品牌型号管理";
            this.btn_brandSet.Click += new System.EventHandler(this.btn_brandSet_Click);
            // 
            // btn_indicatorSet
            // 
            this.btn_indicatorSet.Name = "btn_indicatorSet";
            this.btn_indicatorSet.SubItemsExpandWidth = 14;
            this.btn_indicatorSet.Text = "指标项管理";
            this.btn_indicatorSet.Click += new System.EventHandler(this.btn_indicatorSet_Click);
            // 
            // btn_taskReport
            // 
            this.btn_taskReport.Name = "btn_taskReport";
            this.btn_taskReport.SubItemsExpandWidth = 14;
            this.btn_taskReport.Text = "测试报告";
            this.btn_taskReport.Click += new System.EventHandler(this.btn_taskReport_Click);
            // 
            // panelExMain
            // 
            this.panelExMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExMain.Controls.Add(this.taskMainPanel);
            this.panelExMain.Controls.Add(this.slidePanelMain);
            this.panelExMain.Controls.Add(this.expandablePanel);
            this.panelExMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExMain.Location = new System.Drawing.Point(0, 109);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(1259, 646);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 2;
            this.panelExMain.Text = "panelEx3";
            // 
            // slidePanelMain
            // 
            this.slidePanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePanelMain.Location = new System.Drawing.Point(150, 0);
            this.slidePanelMain.Name = "slidePanelMain";
            this.slidePanelMain.Size = new System.Drawing.Size(1109, 646);
            this.slidePanelMain.TabIndex = 1;
            this.slidePanelMain.Text = "slidePanel1";
            // 
            // expandablePanel
            // 
            this.expandablePanel.AutoScroll = true;
            this.expandablePanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel.Controls.Add(this.taskProcessSlidePanel);
            this.expandablePanel.Controls.Add(this.taskChartSlidePanel);
            this.expandablePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel.Location = new System.Drawing.Point(0, 0);
            this.expandablePanel.MaximumSize = new System.Drawing.Size(150, 0);
            this.expandablePanel.Name = "expandablePanel";
            this.expandablePanel.Size = new System.Drawing.Size(150, 646);
            this.expandablePanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel.Style.GradientAngle = 90;
            this.expandablePanel.TabIndex = 0;
            this.expandablePanel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel.TitleStyle.GradientAngle = 90;
            this.expandablePanel.TitleText = "Title Bar";
            // 
            // taskMainPanel
            // 
            this.taskMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskMainPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskMainPanel.Location = new System.Drawing.Point(150, 0);
            this.taskMainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskMainPanel.Name = "taskMainPanel";
            this.taskMainPanel.Size = new System.Drawing.Size(1109, 646);
            this.taskMainPanel.TabIndex = 3;
            // 
            // taskProcessSlidePanel
            // 
            this.taskProcessSlidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskProcessSlidePanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskProcessSlidePanel.Location = new System.Drawing.Point(0, 26);
            this.taskProcessSlidePanel.Name = "taskProcessSlidePanel";
            this.taskProcessSlidePanel.Size = new System.Drawing.Size(150, 620);
            this.taskProcessSlidePanel.TabIndex = 1;
            // 
            // taskChartSlidePanel
            // 
            this.taskChartSlidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskChartSlidePanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.taskChartSlidePanel.Location = new System.Drawing.Point(0, 26);
            this.taskChartSlidePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.taskChartSlidePanel.Name = "taskChartSlidePanel";
            this.taskChartSlidePanel.Size = new System.Drawing.Size(150, 620);
            this.taskChartSlidePanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 755);
            this.Controls.Add(this.panelExMain);
            this.Controls.Add(this.ribbonBar1);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "航空安全实验基地智能监控系统检测平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelEx1.ResumeLayout(false);
            this.panelExMain.ResumeLayout(false);
            this.expandablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btn_item_home;
        private DevComponents.DotNetBar.ButtonItem btn_item_taskManager;
        private DevComponents.DotNetBar.ButtonItem btn_item_alarm;
        private DevComponents.DotNetBar.PanelEx panelExMain;
        private DevComponents.DotNetBar.ButtonItem btn_brandSet;
        private DevComponents.DotNetBar.ButtonItem btn_indicatorSet;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanelMain;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel;
        private UserControls.TaskProcessSlidePanel taskProcessSlidePanel;
        private UserControls.TaskChartSlidePanel taskChartSlidePanel;
        private UserControls.TaskMainPanel taskMainPanel;
        private DevComponents.DotNetBar.ButtonItem btn_taskReport;
    }
}