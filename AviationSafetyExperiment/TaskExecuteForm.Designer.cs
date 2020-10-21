namespace AviationSafetyExperiment
{
    partial class TaskExecuteForm
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
            this.btn_newRound = new DevComponents.DotNetBar.ButtonX();
            this.btn_reject = new DevComponents.DotNetBar.ButtonX();
            this.btn_pass = new DevComponents.DotNetBar.ButtonX();
            this.btn_close = new DevComponents.DotNetBar.ButtonX();
            this.btn_done = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.showTaskRound_Panel = new DevComponents.DotNetBar.PanelEx();
            this.lbl_round = new DevComponents.DotNetBar.LabelX();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.btn_previous = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.trp = new AviationSafetyExperiment.UserControls.TaskResultPanel();
            this.tdbip = new AviationSafetyExperiment.UserControls.TaskDetialBaseInfoPanel();
            this.showTaskRound_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_newRound
            // 
            this.btn_newRound.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_newRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newRound.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_newRound.Image = global::AviationSafetyExperiment.Properties.Resources._16;
            this.btn_newRound.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btn_newRound.Location = new System.Drawing.Point(1072, 12);
            this.btn_newRound.Name = "btn_newRound";
            this.btn_newRound.Size = new System.Drawing.Size(94, 34);
            this.btn_newRound.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_newRound.TabIndex = 6;
            this.btn_newRound.Text = "新增伦次";
            this.btn_newRound.Click += new System.EventHandler(this.btn_newRound_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_reject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_reject.Image = global::AviationSafetyExperiment.Properties.Resources.s_25;
            this.btn_reject.Location = new System.Drawing.Point(1268, 52);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(90, 34);
            this.btn_reject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_reject.TabIndex = 4;
            this.btn_reject.Text = "驳回";
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // btn_pass
            // 
            this.btn_pass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_pass.Image = global::AviationSafetyExperiment.Properties.Resources.s_24;
            this.btn_pass.Location = new System.Drawing.Point(1170, 52);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(94, 34);
            this.btn_pass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_pass.TabIndex = 3;
            this.btn_pass.Text = "通过";
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // btn_close
            // 
            this.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_close.Image = global::AviationSafetyExperiment.Properties.Resources.s_25;
            this.btn_close.Location = new System.Drawing.Point(1268, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 34);
            this.btn_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "关闭任务";
            this.btn_close.Click += new System.EventHandler(this.ben_close_Click);
            // 
            // btn_done
            // 
            this.btn_done.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_done.Image = global::AviationSafetyExperiment.Properties.Resources.s_24;
            this.btn_done.Location = new System.Drawing.Point(1170, 12);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(94, 34);
            this.btn_done.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_done.TabIndex = 1;
            this.btn_done.Text = "完成任务";
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Image = global::AviationSafetyExperiment.Properties.Resources.s_23;
            this.btn_save.Location = new System.Drawing.Point(973, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 34);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存任务";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // showTaskRound_Panel
            // 
            this.showTaskRound_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showTaskRound_Panel.CanvasColor = System.Drawing.SystemColors.Control;
            this.showTaskRound_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.showTaskRound_Panel.Controls.Add(this.lbl_round);
            this.showTaskRound_Panel.Controls.Add(this.btn_next);
            this.showTaskRound_Panel.Controls.Add(this.btn_previous);
            this.showTaskRound_Panel.Controls.Add(this.labelX1);
            this.showTaskRound_Panel.Location = new System.Drawing.Point(1170, 52);
            this.showTaskRound_Panel.Name = "showTaskRound_Panel";
            this.showTaskRound_Panel.Size = new System.Drawing.Size(188, 47);
            this.showTaskRound_Panel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.showTaskRound_Panel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.showTaskRound_Panel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.showTaskRound_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.showTaskRound_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.showTaskRound_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.showTaskRound_Panel.Style.GradientAngle = 90;
            this.showTaskRound_Panel.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.showTaskRound_Panel.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.showTaskRound_Panel.StyleMouseDown.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.showTaskRound_Panel.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showTaskRound_Panel.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(204)))));
            this.showTaskRound_Panel.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(117)))));
            this.showTaskRound_Panel.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(105)))));
            this.showTaskRound_Panel.StyleMouseOver.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.showTaskRound_Panel.TabIndex = 7;
            // 
            // lbl_round
            // 
            this.lbl_round.AutoSize = true;
            // 
            // 
            // 
            this.lbl_round.BackgroundStyle.Class = "";
            this.lbl_round.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_round.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_round.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_round.Location = new System.Drawing.Point(90, 13);
            this.lbl_round.Name = "lbl_round";
            this.lbl_round.Size = new System.Drawing.Size(31, 23);
            this.lbl_round.TabIndex = 4;
            this.lbl_round.Text = "1/1";
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Location = new System.Drawing.Point(132, 13);
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
            this.btn_previous.Location = new System.Drawing.Point(50, 13);
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
            this.labelX1.Location = new System.Drawing.Point(5, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(44, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "轮次：";
            // 
            // trp
            // 
            this.trp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trp.Location = new System.Drawing.Point(0, 106);
            this.trp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trp.Name = "trp";
            this.trp.Size = new System.Drawing.Size(1370, 643);
            this.trp.TabIndex = 1;
            // 
            // tdbip
            // 
            this.tdbip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tdbip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tdbip.Location = new System.Drawing.Point(0, 0);
            this.tdbip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tdbip.Name = "tdbip";
            this.tdbip.Size = new System.Drawing.Size(1370, 106);
            this.tdbip.TabIndex = 0;
            // 
            // TaskExecuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_newRound);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.trp);
            this.Controls.Add(this.showTaskRound_Panel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tdbip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskExecuteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试任务处理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TaskExecuteForm_Shown);
            this.showTaskRound_Panel.ResumeLayout(false);
            this.showTaskRound_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TaskDetialBaseInfoPanel tdbip;
        private UserControls.TaskResultPanel trp;
        private DevComponents.DotNetBar.ButtonX btn_close;
        private DevComponents.DotNetBar.ButtonX btn_done;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_reject;
        private DevComponents.DotNetBar.ButtonX btn_pass;
        private DevComponents.DotNetBar.ButtonX btn_newRound;
        private DevComponents.DotNetBar.PanelEx showTaskRound_Panel;
        private DevComponents.DotNetBar.LabelX lbl_round;
        private DevComponents.DotNetBar.ButtonX btn_next;
        private DevComponents.DotNetBar.ButtonX btn_previous;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}