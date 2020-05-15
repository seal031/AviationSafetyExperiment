namespace AviationSafetyExperiment
{
    partial class BrandEdit
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
            this.lbl_class = new DevComponents.DotNetBar.LabelX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.lbl_brand = new DevComponents.DotNetBar.LabelX();
            this.lbl_value = new DevComponents.DotNetBar.LabelX();
            this.lbl_classValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_brandValue = new DevComponents.DotNetBar.LabelX();
            this.txt_value = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            // 
            // 
            // 
            this.lbl_class.BackgroundStyle.Class = "";
            this.lbl_class.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_class.Location = new System.Drawing.Point(15, 8);
            this.lbl_class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(54, 24);
            this.lbl_class.TabIndex = 0;
            this.lbl_class.Text = "分类：";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(414, 141);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 31);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "确定";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            // 
            // 
            // 
            this.lbl_brand.BackgroundStyle.Class = "";
            this.lbl_brand.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_brand.Location = new System.Drawing.Point(14, 48);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(54, 24);
            this.lbl_brand.TabIndex = 2;
            this.lbl_brand.Text = "品牌：";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            // 
            // 
            // 
            this.lbl_value.BackgroundStyle.Class = "";
            this.lbl_value.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_value.Location = new System.Drawing.Point(14, 91);
            this.lbl_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(62, 24);
            this.lbl_value.TabIndex = 3;
            this.lbl_value.Text = "labelX3";
            // 
            // lbl_classValue
            // 
            this.lbl_classValue.AutoSize = true;
            // 
            // 
            // 
            this.lbl_classValue.BackgroundStyle.Class = "";
            this.lbl_classValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_classValue.Location = new System.Drawing.Point(124, 8);
            this.lbl_classValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_classValue.Name = "lbl_classValue";
            this.lbl_classValue.Size = new System.Drawing.Size(62, 24);
            this.lbl_classValue.TabIndex = 4;
            this.lbl_classValue.Text = "labelX4";
            // 
            // lbl_brandValue
            // 
            this.lbl_brandValue.AutoSize = true;
            // 
            // 
            // 
            this.lbl_brandValue.BackgroundStyle.Class = "";
            this.lbl_brandValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_brandValue.Location = new System.Drawing.Point(124, 48);
            this.lbl_brandValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_brandValue.Name = "lbl_brandValue";
            this.lbl_brandValue.Size = new System.Drawing.Size(62, 24);
            this.lbl_brandValue.TabIndex = 5;
            this.lbl_brandValue.Text = "labelX5";
            // 
            // txt_value
            // 
            // 
            // 
            // 
            this.txt_value.Border.Class = "TextBoxBorder";
            this.txt_value.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_value.Location = new System.Drawing.Point(124, 91);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(374, 32);
            this.txt_value.TabIndex = 6;
            // 
            // BrandEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 177);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.lbl_brandValue);
            this.Controls.Add(this.lbl_classValue);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_class);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BrandEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.BrandEdit_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_class;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.LabelX lbl_brand;
        private DevComponents.DotNetBar.LabelX lbl_value;
        private DevComponents.DotNetBar.LabelX lbl_classValue;
        private DevComponents.DotNetBar.LabelX lbl_brandValue;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_value;
    }
}