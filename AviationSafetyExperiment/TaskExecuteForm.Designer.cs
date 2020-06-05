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
            this.tdbip = new AviationSafetyExperiment.UserControls.TaskDetialBaseInfoPanel();
            this.trp = new AviationSafetyExperiment.UserControls.TaskResultPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_done = new DevComponents.DotNetBar.ButtonX();
            this.ben_close = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tdbip
            // 
            this.tdbip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tdbip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tdbip.Location = new System.Drawing.Point(0, 0);
            this.tdbip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tdbip.Name = "tdbip";
            this.tdbip.Size = new System.Drawing.Size(1182, 150);
            this.tdbip.TabIndex = 0;
            // 
            // trp
            // 
            this.trp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trp.Location = new System.Drawing.Point(0, 150);
            this.trp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trp.Name = "trp";
            this.trp.Size = new System.Drawing.Size(1182, 603);
            this.trp.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.ben_close);
            this.groupPanel1.Controls.Add(this.btn_done);
            this.groupPanel1.Controls.Add(this.btn_save);
            this.groupPanel1.Location = new System.Drawing.Point(885, 76);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(291, 71);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "操作";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(15, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 34);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "保存任务";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_done
            // 
            this.btn_done.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_done.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_done.Location = new System.Drawing.Point(106, 3);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(77, 34);
            this.btn_done.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_done.TabIndex = 1;
            this.btn_done.Text = "完成任务";
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // ben_close
            // 
            this.ben_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ben_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ben_close.Location = new System.Drawing.Point(195, 4);
            this.ben_close.Name = "ben_close";
            this.ben_close.Size = new System.Drawing.Size(77, 34);
            this.ben_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ben_close.TabIndex = 2;
            this.ben_close.Text = "关闭任务";
            this.ben_close.Click += new System.EventHandler(this.ben_close_Click);
            // 
            // TaskExecuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.trp);
            this.Controls.Add(this.tdbip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskExecuteForm";
            this.Text = "测试任务处理";
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TaskDetialBaseInfoPanel tdbip;
        private UserControls.TaskResultPanel trp;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX ben_close;
        private DevComponents.DotNetBar.ButtonX btn_done;
        private DevComponents.DotNetBar.ButtonX btn_save;
    }
}