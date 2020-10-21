namespace AviationSafetyExperiment
{
    partial class TaskDetial
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
            this.btn_report = new DevComponents.DotNetBar.ButtonX();
            this.panel_history = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lbl_current = new DevComponents.DotNetBar.LabelX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.btn_previous = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ben_closeHistory = new DevComponents.DotNetBar.ButtonX();
            this.lbl_showHistory = new DevComponents.DotNetBar.LabelX();
            this.tdbip = new AviationSafetyExperiment.UserControls.TaskDetialBaseInfoPanel();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.tlp = new AviationSafetyExperiment.UserControls.TaskLifecyclePanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.trp = new AviationSafetyExperiment.UserControls.TaskResultPanel();
            this.lbl_roundText = new DevComponents.DotNetBar.LabelX();
            this.Btn_nextRound = new DevComponents.DotNetBar.ButtonX();
            this.Btn_lastRound = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.panel_history.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_report);
            this.panelEx1.Controls.Add(this.panel_history);
            this.panelEx1.Controls.Add(this.lbl_showHistory);
            this.panelEx1.Controls.Add(this.tdbip);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1370, 104);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // btn_report
            // 
            this.btn_report.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_report.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_report.Location = new System.Drawing.Point(620, 46);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(98, 35);
            this.btn_report.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "报告生成";
            this.btn_report.Click += new System.EventHandler(this.reportCreate_Click);
            // 
            // panel_history
            // 
            this.panel_history.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_history.CanvasColor = System.Drawing.SystemColors.Control;
            this.panel_history.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panel_history.Controls.Add(this.lbl_roundText);
            this.panel_history.Controls.Add(this.Btn_nextRound);
            this.panel_history.Controls.Add(this.Btn_lastRound);
            this.panel_history.Controls.Add(this.labelX2);
            this.panel_history.Controls.Add(this.lbl_current);
            this.panel_history.Controls.Add(this.btn_next);
            this.panel_history.Controls.Add(this.btn_previous);
            this.panel_history.Controls.Add(this.labelX1);
            this.panel_history.Controls.Add(this.ben_closeHistory);
            this.panel_history.Location = new System.Drawing.Point(855, 36);
            this.panel_history.Name = "panel_history";
            this.panel_history.Size = new System.Drawing.Size(467, 47);
            this.panel_history.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panel_history.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panel_history.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panel_history.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel_history.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panel_history.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panel_history.Style.GradientAngle = 90;
            this.panel_history.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.panel_history.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.panel_history.StyleMouseDown.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.panel_history.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_history.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(204)))));
            this.panel_history.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(117)))));
            this.panel_history.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.panel_history.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_history.TabIndex = 2;
            this.panel_history.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(10, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 20);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "现有轮次：";
            // 
            // lbl_current
            // 
            this.lbl_current.AutoSize = true;
            // 
            // 
            // 
            this.lbl_current.BackgroundStyle.Class = "";
            this.lbl_current.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_current.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_current.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_current.Location = new System.Drawing.Point(283, 12);
            this.lbl_current.Name = "lbl_current";
            this.lbl_current.Size = new System.Drawing.Size(37, 23);
            this.lbl_current.TabIndex = 4;
            this.lbl_current.Text = "步骤";
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Location = new System.Drawing.Point(325, 12);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(29, 23);
            this.btn_next.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = ">>";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_previous.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_previous.Location = new System.Drawing.Point(248, 12);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(29, 23);
            this.btn_previous.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_previous.TabIndex = 2;
            this.btn_previous.Text = "<<";
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(208, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "步骤：";
            // 
            // ben_closeHistory
            // 
            this.ben_closeHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ben_closeHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ben_closeHistory.Location = new System.Drawing.Point(368, 12);
            this.ben_closeHistory.Name = "ben_closeHistory";
            this.ben_closeHistory.Size = new System.Drawing.Size(75, 23);
            this.ben_closeHistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ben_closeHistory.TabIndex = 0;
            this.ben_closeHistory.Text = "关闭历程";
            this.ben_closeHistory.Click += new System.EventHandler(this.ben_closeHistory_Click);
            // 
            // lbl_showHistory
            // 
            this.lbl_showHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_showHistory.AutoSize = true;
            // 
            // 
            // 
            this.lbl_showHistory.BackgroundStyle.Class = "";
            this.lbl_showHistory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_showHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_showHistory.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_showHistory.Location = new System.Drawing.Point(855, 12);
            this.lbl_showHistory.Name = "lbl_showHistory";
            this.lbl_showHistory.Size = new System.Drawing.Size(81, 20);
            this.lbl_showHistory.TabIndex = 1;
            this.lbl_showHistory.Text = "查看测试历程";
            this.lbl_showHistory.Click += new System.EventHandler(this.lbl_showHistory_Click);
            // 
            // tdbip
            // 
            this.tdbip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdbip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tdbip.Location = new System.Drawing.Point(0, 0);
            this.tdbip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tdbip.Name = "tdbip";
            this.tdbip.Size = new System.Drawing.Size(1370, 104);
            this.tdbip.TabIndex = 0;
            this.tdbip.Load += new System.EventHandler(this.tdbip_Load);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.tlp);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 629);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1370, 120);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            this.panelEx3.Text = "panelEx3";
            // 
            // tlp
            // 
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlp.Name = "tlp";
            this.tlp.Size = new System.Drawing.Size(1370, 120);
            this.tlp.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.trp);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 104);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1370, 525);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 3;
            this.panelEx2.Text = "panelEx2";
            // 
            // trp
            // 
            this.trp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trp.Location = new System.Drawing.Point(0, 0);
            this.trp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trp.Name = "trp";
            this.trp.Size = new System.Drawing.Size(1370, 525);
            this.trp.TabIndex = 0;
            // 
            // lbl_roundText
            // 
            this.lbl_roundText.AutoSize = true;
            // 
            // 
            // 
            this.lbl_roundText.BackgroundStyle.Class = "";
            this.lbl_roundText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_roundText.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_roundText.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_roundText.Location = new System.Drawing.Point(109, 12);
            this.lbl_roundText.Name = "lbl_roundText";
            this.lbl_roundText.Size = new System.Drawing.Size(37, 23);
            this.lbl_roundText.TabIndex = 11;
            this.lbl_roundText.Text = "轮次";
            // 
            // Btn_nextRound
            // 
            this.Btn_nextRound.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_nextRound.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_nextRound.Location = new System.Drawing.Point(148, 12);
            this.Btn_nextRound.Name = "Btn_nextRound";
            this.Btn_nextRound.Size = new System.Drawing.Size(29, 23);
            this.Btn_nextRound.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_nextRound.TabIndex = 10;
            this.Btn_nextRound.Text = ">>";
            this.Btn_nextRound.Click += new System.EventHandler(this.Btn_nextRound_Click);
            // 
            // Btn_lastRound
            // 
            this.Btn_lastRound.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Btn_lastRound.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Btn_lastRound.Location = new System.Drawing.Point(73, 12);
            this.Btn_lastRound.Name = "Btn_lastRound";
            this.Btn_lastRound.Size = new System.Drawing.Size(29, 23);
            this.Btn_lastRound.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Btn_lastRound.TabIndex = 9;
            this.Btn_lastRound.Text = "<<";
            this.Btn_lastRound.Click += new System.EventHandler(this.Btn_lastRound_Click);
            // 
            // TaskDetial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskDetial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试任务详情";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panel_history.ResumeLayout(false);
            this.panel_history.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private UserControls.TaskDetialBaseInfoPanel tdbip;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private UserControls.TaskResultPanel trp;
        private UserControls.TaskLifecyclePanel tlp;
        private DevComponents.DotNetBar.LabelX lbl_showHistory;
        private DevComponents.DotNetBar.PanelEx panel_history;
        private DevComponents.DotNetBar.ButtonX btn_next;
        private DevComponents.DotNetBar.ButtonX btn_previous;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX ben_closeHistory;
        private DevComponents.DotNetBar.LabelX lbl_current;
        private DevComponents.DotNetBar.ButtonX btn_report;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lbl_roundText;
        private DevComponents.DotNetBar.ButtonX Btn_nextRound;
        private DevComponents.DotNetBar.ButtonX Btn_lastRound;
    }
}