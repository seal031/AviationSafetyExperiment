namespace AviationSafetyExperiment
{
    partial class TaskReject
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_reason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_reject = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 24);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "驳回原因";
            // 
            // txt_reason
            // 
            // 
            // 
            // 
            this.txt_reason.Border.Class = "TextBoxBorder";
            this.txt_reason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_reason.Location = new System.Drawing.Point(13, 53);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(456, 101);
            this.txt_reason.TabIndex = 1;
            // 
            // btn_reject
            // 
            this.btn_reject.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_reject.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_reject.Location = new System.Drawing.Point(195, 162);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(96, 39);
            this.btn_reject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_reject.TabIndex = 2;
            this.btn_reject.Text = "确 定";
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // TaskReject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 202);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskReject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试任务驳回";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_reason;
        private DevComponents.DotNetBar.ButtonX btn_reject;
    }
}