namespace AviationSafetyExperiment
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_username_old = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_password_old = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_login_old = new DevComponents.DotNetBar.ButtonX();
            this.btn_login = new DevComponents.DotNetBar.ButtonX();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_username_old
            // 
            // 
            // 
            // 
            this.txt_username_old.Border.Class = "";
            this.txt_username_old.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_username_old.Location = new System.Drawing.Point(1020, 296);
            this.txt_username_old.Name = "txt_username_old";
            this.txt_username_old.Size = new System.Drawing.Size(180, 25);
            this.txt_username_old.TabIndex = 11;
            this.txt_username_old.Visible = false;
            // 
            // txt_password_old
            // 
            // 
            // 
            // 
            this.txt_password_old.Border.Class = "";
            this.txt_password_old.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_password_old.Location = new System.Drawing.Point(1020, 333);
            this.txt_password_old.Name = "txt_password_old";
            this.txt_password_old.PasswordChar = '*';
            this.txt_password_old.Size = new System.Drawing.Size(180, 25);
            this.txt_password_old.TabIndex = 12;
            this.txt_password_old.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.Location = new System.Drawing.Point(971, 299);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(43, 24);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "账 号";
            this.labelX1.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.Location = new System.Drawing.Point(971, 336);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(43, 24);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "密 码";
            this.labelX2.Visible = false;
            // 
            // btn_login_old
            // 
            this.btn_login_old.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login_old.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_login_old.Location = new System.Drawing.Point(1100, 211);
            this.btn_login_old.Name = "btn_login_old";
            this.btn_login_old.Size = new System.Drawing.Size(82, 69);
            this.btn_login_old.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_login_old.TabIndex = 13;
            this.btn_login_old.Text = "登录";
            this.btn_login_old.Visible = false;
            this.btn_login_old.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btn_login.Location = new System.Drawing.Point(467, 435);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(259, 35);
            this.btn_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_login.TabIndex = 2;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_password.Location = new System.Drawing.Point(504, 381);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(218, 29);
            this.txt_password.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_username.Location = new System.Drawing.Point(505, 338);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(218, 29);
            this.txt_username.TabIndex = 0;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login_old;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1223, 632);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_login_old);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_password_old);
            this.Controls.Add(this.txt_username_old);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IconTooltip = "航科院航空安全实验基地";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txt_username_old;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_password_old;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_login_old;
        private DevComponents.DotNetBar.ButtonX btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
    }
}

