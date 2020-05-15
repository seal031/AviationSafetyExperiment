namespace AviationSafetyExperiment
{
    partial class BrandManage
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_editClass = new DevComponents.DotNetBar.ButtonX();
            this.btn_addClass = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_editBrand = new DevComponents.DotNetBar.ButtonX();
            this.btn_addBrand = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_editModel = new DevComponents.DotNetBar.ButtonX();
            this.btn_addModel = new DevComponents.DotNetBar.ButtonX();
            this.ip_brand = new System.Windows.Forms.ListBox();
            this.ip_model = new System.Windows.Forms.ListBox();
            this.ip_class = new System.Windows.Forms.ListBox();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.ip_class);
            this.groupPanel1.Controls.Add(this.btn_editClass);
            this.groupPanel1.Controls.Add(this.btn_addClass);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(300, 514);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "分类管理";
            // 
            // btn_editClass
            // 
            this.btn_editClass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editClass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editClass.Location = new System.Drawing.Point(201, 441);
            this.btn_editClass.Name = "btn_editClass";
            this.btn_editClass.Size = new System.Drawing.Size(75, 23);
            this.btn_editClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editClass.TabIndex = 2;
            this.btn_editClass.Text = "编辑分类";
            this.btn_editClass.Click += new System.EventHandler(this.btn_editClass_Click);
            // 
            // btn_addClass
            // 
            this.btn_addClass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addClass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addClass.Location = new System.Drawing.Point(32, 441);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(75, 23);
            this.btn_addClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addClass.TabIndex = 1;
            this.btn_addClass.Text = "新增分类";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.ip_brand);
            this.groupPanel2.Controls.Add(this.btn_editBrand);
            this.groupPanel2.Controls.Add(this.btn_addBrand);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel2.Location = new System.Drawing.Point(300, 0);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(300, 514);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "品牌管理";
            // 
            // btn_editBrand
            // 
            this.btn_editBrand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editBrand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editBrand.Location = new System.Drawing.Point(195, 441);
            this.btn_editBrand.Name = "btn_editBrand";
            this.btn_editBrand.Size = new System.Drawing.Size(75, 23);
            this.btn_editBrand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editBrand.TabIndex = 4;
            this.btn_editBrand.Text = "编辑品牌";
            this.btn_editBrand.Click += new System.EventHandler(this.btn_editBrand_Click);
            // 
            // btn_addBrand
            // 
            this.btn_addBrand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addBrand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addBrand.Location = new System.Drawing.Point(26, 441);
            this.btn_addBrand.Name = "btn_addBrand";
            this.btn_addBrand.Size = new System.Drawing.Size(75, 23);
            this.btn_addBrand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addBrand.TabIndex = 3;
            this.btn_addBrand.Text = "新增品牌";
            this.btn_addBrand.Click += new System.EventHandler(this.btn_addBrand_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.ip_model);
            this.groupPanel3.Controls.Add(this.btn_editModel);
            this.groupPanel3.Controls.Add(this.btn_addModel);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel3.Location = new System.Drawing.Point(600, 0);
            this.groupPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(300, 514);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.Class = "";
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.Class = "";
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.Class = "";
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            this.groupPanel3.Text = "型号管理";
            // 
            // btn_editModel
            // 
            this.btn_editModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editModel.Location = new System.Drawing.Point(198, 441);
            this.btn_editModel.Name = "btn_editModel";
            this.btn_editModel.Size = new System.Drawing.Size(75, 23);
            this.btn_editModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editModel.TabIndex = 4;
            this.btn_editModel.Text = "编辑型号";
            this.btn_editModel.Click += new System.EventHandler(this.btn_editModel_Click);
            // 
            // btn_addModel
            // 
            this.btn_addModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addModel.Location = new System.Drawing.Point(29, 441);
            this.btn_addModel.Name = "btn_addModel";
            this.btn_addModel.Size = new System.Drawing.Size(75, 23);
            this.btn_addModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addModel.TabIndex = 3;
            this.btn_addModel.Text = "新增型号";
            this.btn_addModel.Click += new System.EventHandler(this.btn_addModel_Click);
            // 
            // ip_brand
            // 
            this.ip_brand.Dock = System.Windows.Forms.DockStyle.Top;
            this.ip_brand.FormattingEnabled = true;
            this.ip_brand.ItemHeight = 20;
            this.ip_brand.Location = new System.Drawing.Point(0, 0);
            this.ip_brand.Name = "ip_brand";
            this.ip_brand.Size = new System.Drawing.Size(294, 424);
            this.ip_brand.TabIndex = 5;
            this.ip_brand.SelectedIndexChanged += new System.EventHandler(this.ip_brand_SelectedIndexChanged);
            this.ip_brand.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ip_brand_MouseDoubleClick);
            // 
            // ip_model
            // 
            this.ip_model.Dock = System.Windows.Forms.DockStyle.Top;
            this.ip_model.FormattingEnabled = true;
            this.ip_model.ItemHeight = 20;
            this.ip_model.Location = new System.Drawing.Point(0, 0);
            this.ip_model.Name = "ip_model";
            this.ip_model.Size = new System.Drawing.Size(294, 424);
            this.ip_model.TabIndex = 5;
            this.ip_model.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ip_model_MouseDoubleClick);
            // 
            // ip_class
            // 
            this.ip_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.ip_class.FormattingEnabled = true;
            this.ip_class.ItemHeight = 20;
            this.ip_class.Location = new System.Drawing.Point(0, 0);
            this.ip_class.Name = "ip_class";
            this.ip_class.Size = new System.Drawing.Size(294, 424);
            this.ip_class.TabIndex = 6;
            this.ip_class.SelectedIndexChanged += new System.EventHandler(this.ip_class_SelectedIndexChanged);
            this.ip_class.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ip_class_MouseDoubleClick);
            // 
            // BrandManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 514);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BrandManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分类/品牌/型号 管理";
            this.Shown += new System.EventHandler(this.BrandManage_Shown);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btn_editClass;
        private DevComponents.DotNetBar.ButtonX btn_addClass;
        private DevComponents.DotNetBar.ButtonX btn_editBrand;
        private DevComponents.DotNetBar.ButtonX btn_addBrand;
        private DevComponents.DotNetBar.ButtonX btn_editModel;
        private DevComponents.DotNetBar.ButtonX btn_addModel;
        private System.Windows.Forms.ListBox ip_brand;
        private System.Windows.Forms.ListBox ip_model;
        private System.Windows.Forms.ListBox ip_class;
    }
}