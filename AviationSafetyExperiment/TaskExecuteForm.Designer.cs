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
            this.trp = new AviationSafetyExperiment.UserControls.TaskResultPanel();
            this.tdbip = new AviationSafetyExperiment.UserControls.TaskDetialBaseInfoPanel();
            this.ribbonBar_taskRound = new DevComponents.DotNetBar.RibbonBar();
            this.btn_newRound = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btn_reject = new DevComponents.DotNetBar.ButtonX();
            this.btn_pass = new DevComponents.DotNetBar.ButtonX();
            this.btn_close = new DevComponents.DotNetBar.ButtonX();
            this.btn_done = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
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
            // ribbonBar_taskRound
            // 
            this.ribbonBar_taskRound.AutoOverflowEnabled = true;
            this.ribbonBar_taskRound.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ribbonBar_taskRound.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar_taskRound.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_taskRound.BackgroundStyle.Class = "";
            this.ribbonBar_taskRound.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_taskRound.ContainerControlProcessDialogKey = true;
            this.ribbonBar_taskRound.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_newRound,
            this.labelItem2,
            this.labelItem1});
            this.ribbonBar_taskRound.Location = new System.Drawing.Point(715, 52);
            this.ribbonBar_taskRound.Name = "ribbonBar_taskRound";
            this.ribbonBar_taskRound.Size = new System.Drawing.Size(385, 47);
            this.ribbonBar_taskRound.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar_taskRound.TabIndex = 5;
            this.ribbonBar_taskRound.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar_taskRound.TitleStyle.Class = "";
            this.ribbonBar_taskRound.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_taskRound.TitleStyleMouseOver.Class = "";
            this.ribbonBar_taskRound.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_taskRound.TitleVisible = false;
            // 
            // btn_newRound
            // 
            this.btn_newRound.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btn_newRound.FontBold = true;
            this.btn_newRound.Image = global::AviationSafetyExperiment.Properties.Resources._15;
            this.btn_newRound.ImagePaddingHorizontal = 2;
            this.btn_newRound.Name = "btn_newRound";
            this.btn_newRound.ShowSubItems = false;
            this.btn_newRound.SubItemsExpandWidth = 14;
            this.btn_newRound.Text = "新增一轮";
            this.btn_newRound.Click += new System.EventHandler(this.btn_newRound_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "    ";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "现有轮次";
            // 
            // btn_reject
            // 
            this.btn_reject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_reject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_reject.Image = global::AviationSafetyExperiment.Properties.Resources.s_25;
            this.btn_reject.Location = new System.Drawing.Point(1300, 52);
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
            this.btn_pass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_pass.Image = global::AviationSafetyExperiment.Properties.Resources.s_24;
            this.btn_pass.Location = new System.Drawing.Point(1202, 52);
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
            this.btn_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_close.Image = global::AviationSafetyExperiment.Properties.Resources.s_25;
            this.btn_close.Location = new System.Drawing.Point(1300, 12);
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
            this.btn_done.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_done.Image = global::AviationSafetyExperiment.Properties.Resources.s_24;
            this.btn_done.Location = new System.Drawing.Point(1202, 12);
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
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Image = global::AviationSafetyExperiment.Properties.Resources.s_23;
            this.btn_save.Location = new System.Drawing.Point(1104, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 34);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存任务";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // TaskExecuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ribbonBar_taskRound);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.trp);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tdbip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskExecuteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试任务处理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TaskExecuteForm_Shown);
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
        private DevComponents.DotNetBar.RibbonBar ribbonBar_taskRound;
        private DevComponents.DotNetBar.ButtonItem btn_newRound;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem2;
    }
}