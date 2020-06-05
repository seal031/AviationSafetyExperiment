namespace AviationSafetyExperiment.UserControls
{
    partial class TaskQueryPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_taskQueryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_taskQueryBrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_query = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_query);
            this.panelEx1.Controls.Add(this.txt_taskQueryBrand);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.txt_taskQueryName);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1034, 47);
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
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(50, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 24);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "任务名称";
            // 
            // txt_taskQueryName
            // 
            // 
            // 
            // 
            this.txt_taskQueryName.Border.Class = "TextBoxBorder";
            this.txt_taskQueryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_taskQueryName.Location = new System.Drawing.Point(118, 8);
            this.txt_taskQueryName.Name = "txt_taskQueryName";
            this.txt_taskQueryName.Size = new System.Drawing.Size(264, 32);
            this.txt_taskQueryName.TabIndex = 1;
            // 
            // txt_taskQueryBrand
            // 
            // 
            // 
            // 
            this.txt_taskQueryBrand.Border.Class = "TextBoxBorder";
            this.txt_taskQueryBrand.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_taskQueryBrand.Location = new System.Drawing.Point(526, 7);
            this.txt_taskQueryBrand.Name = "txt_taskQueryBrand";
            this.txt_taskQueryBrand.Size = new System.Drawing.Size(264, 32);
            this.txt_taskQueryBrand.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(458, 11);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 24);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "测试品牌";
            // 
            // btn_query
            // 
            this.btn_query.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_query.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_query.Location = new System.Drawing.Point(838, 7);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(92, 33);
            this.btn_query.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_query.TabIndex = 4;
            this.btn_query.Text = "查询";
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // TaskQueryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskQueryPanel";
            this.Size = new System.Drawing.Size(1034, 47);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_query;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_taskQueryBrand;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_taskQueryName;
    }
}
