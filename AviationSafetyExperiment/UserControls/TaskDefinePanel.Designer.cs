namespace AviationSafetyExperiment.UserControls
{
    partial class TaskDefinePanel
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
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.its = new AviationSafetyExperiment.UserControls.IndicatorTemplateSelecter();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_brandModel = new DevComponents.DotNetBar.LabelX();
            this.lbl_taskType = new DevComponents.DotNetBar.LabelX();
            this.btn_createTask = new DevComponents.DotNetBar.ButtonX();
            this.btn_pickBrandModel = new DevComponents.DotNetBar.ButtonX();
            this.txt_taskCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbb_taskClass = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_taskExecutor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_taskName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1040, 760);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.its);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 221);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1040, 539);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 15;
            // 
            // its
            // 
            this.its.Dock = System.Windows.Forms.DockStyle.Fill;
            this.its.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.its.isManage = false;
            this.its.Location = new System.Drawing.Point(0, 0);
            this.its.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.its.Name = "its";
            this.its.Size = new System.Drawing.Size(1040, 539);
            this.its.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbl_brandModel);
            this.groupPanel1.Controls.Add(this.lbl_taskType);
            this.groupPanel1.Controls.Add(this.btn_createTask);
            this.groupPanel1.Controls.Add(this.btn_pickBrandModel);
            this.groupPanel1.Controls.Add(this.txt_taskCode);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.cbb_taskClass);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txt_taskExecutor);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txt_taskName);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1040, 221);
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
            this.groupPanel1.TabIndex = 14;
            this.groupPanel1.Text = "新建测试任务";
            // 
            // lbl_brandModel
            // 
            this.lbl_brandModel.AutoSize = true;
            // 
            // 
            // 
            this.lbl_brandModel.BackgroundStyle.BorderBottomWidth = 2;
            this.lbl_brandModel.BackgroundStyle.BorderLeftWidth = 2;
            this.lbl_brandModel.BackgroundStyle.BorderRightWidth = 2;
            this.lbl_brandModel.BackgroundStyle.BorderTopWidth = 2;
            this.lbl_brandModel.BackgroundStyle.Class = "";
            this.lbl_brandModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_brandModel.Location = new System.Drawing.Point(156, 90);
            this.lbl_brandModel.Name = "lbl_brandModel";
            this.lbl_brandModel.Size = new System.Drawing.Size(0, 0);
            this.lbl_brandModel.TabIndex = 27;
            // 
            // lbl_taskType
            // 
            this.lbl_taskType.AutoSize = true;
            // 
            // 
            // 
            this.lbl_taskType.BackgroundStyle.Class = "";
            this.lbl_taskType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_taskType.Location = new System.Drawing.Point(437, 53);
            this.lbl_taskType.Name = "lbl_taskType";
            this.lbl_taskType.Size = new System.Drawing.Size(0, 0);
            this.lbl_taskType.TabIndex = 26;
            // 
            // btn_createTask
            // 
            this.btn_createTask.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_createTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_createTask.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_createTask.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_createTask.Location = new System.Drawing.Point(900, 143);
            this.btn_createTask.Name = "btn_createTask";
            this.btn_createTask.Size = new System.Drawing.Size(99, 45);
            this.btn_createTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_createTask.TabIndex = 25;
            this.btn_createTask.Text = "创建任务";
            this.btn_createTask.Click += new System.EventHandler(this.btn_createTask_Click);
            // 
            // btn_pickBrandModel
            // 
            this.btn_pickBrandModel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_pickBrandModel.AutoSize = true;
            this.btn_pickBrandModel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_pickBrandModel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_pickBrandModel.ForeColor = System.Drawing.Color.Black;
            this.btn_pickBrandModel.Location = new System.Drawing.Point(28, 90);
            this.btn_pickBrandModel.Name = "btn_pickBrandModel";
            this.btn_pickBrandModel.Size = new System.Drawing.Size(104, 30);
            this.btn_pickBrandModel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_pickBrandModel.TabIndex = 24;
            this.btn_pickBrandModel.Text = "品牌型号选择";
            this.btn_pickBrandModel.Click += new System.EventHandler(this.btn_pickBrandModel_Click);
            // 
            // txt_taskCode
            // 
            this.txt_taskCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_taskCode.Border.Class = "TextBoxBorder";
            this.txt_taskCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_taskCode.Location = new System.Drawing.Point(827, 46);
            this.txt_taskCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_taskCode.Name = "txt_taskCode";
            this.txt_taskCode.ReadOnly = true;
            this.txt_taskCode.Size = new System.Drawing.Size(172, 32);
            this.txt_taskCode.TabIndex = 22;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(736, 50);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(85, 24);
            this.labelX5.TabIndex = 21;
            this.labelX5.Text = "测试编码：";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(346, 50);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(85, 24);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "测试类型：";
            // 
            // cbb_taskClass
            // 
            this.cbb_taskClass.DisplayMember = "Text";
            this.cbb_taskClass.FormattingEnabled = true;
            this.cbb_taskClass.ItemHeight = 19;
            this.cbb_taskClass.Location = new System.Drawing.Point(119, 48);
            this.cbb_taskClass.Name = "cbb_taskClass";
            this.cbb_taskClass.Size = new System.Drawing.Size(152, 27);
            this.cbb_taskClass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_taskClass.TabIndex = 19;
            this.cbb_taskClass.SelectedValueChanged += new System.EventHandler(this.cbb_taskClass_SelectedValueChanged);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(28, 50);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(85, 24);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "测试分类：";
            // 
            // txt_taskExecutor
            // 
            this.txt_taskExecutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txt_taskExecutor.Border.Class = "TextBoxBorder";
            this.txt_taskExecutor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_taskExecutor.Location = new System.Drawing.Point(827, 8);
            this.txt_taskExecutor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_taskExecutor.Name = "txt_taskExecutor";
            this.txt_taskExecutor.Size = new System.Drawing.Size(172, 32);
            this.txt_taskExecutor.TabIndex = 17;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(736, 12);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 24);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "测试人员：";
            // 
            // txt_taskName
            // 
            // 
            // 
            // 
            this.txt_taskName.Border.Class = "TextBoxBorder";
            this.txt_taskName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_taskName.Location = new System.Drawing.Point(119, 8);
            this.txt_taskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_taskName.Name = "txt_taskName";
            this.txt_taskName.Size = new System.Drawing.Size(533, 32);
            this.txt_taskName.TabIndex = 15;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(28, 12);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 24);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "任务名称：";
            // 
            // TaskDefinePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskDefinePanel";
            this.Size = new System.Drawing.Size(1040, 760);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lbl_taskType;
        private DevComponents.DotNetBar.ButtonX btn_createTask;
        private DevComponents.DotNetBar.ButtonX btn_pickBrandModel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_taskCode;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_taskClass;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_taskExecutor;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_taskName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private IndicatorTemplateSelecter its;
        private DevComponents.DotNetBar.LabelX lbl_brandModel;
    }
}
