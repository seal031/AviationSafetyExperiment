namespace AviationSafetyExperiment
{
    partial class FtpProcessForm
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
            this.pb = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lbl_state = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // pb
            // 
            // 
            // 
            // 
            this.pb.BackgroundStyle.Class = "";
            this.pb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pb.Location = new System.Drawing.Point(12, 40);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(531, 42);
            this.pb.TabIndex = 0;
            this.pb.TextVisible = true;
            // 
            // lbl_state
            // 
            // 
            // 
            // 
            this.lbl_state.BackgroundStyle.Class = "";
            this.lbl_state.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_state.Location = new System.Drawing.Point(13, 11);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(530, 23);
            this.lbl_state.TabIndex = 1;
            this.lbl_state.Text = "正在传输…………";
            this.lbl_state.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FtpProcessForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(555, 89);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FtpProcessForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件传输进度";
            this.Shown += new System.EventHandler(this.FtpProcessForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX pb;
        private DevComponents.DotNetBar.LabelX lbl_state;
    }
}