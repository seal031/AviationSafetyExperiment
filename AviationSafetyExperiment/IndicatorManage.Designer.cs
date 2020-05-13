namespace AviationSafetyExperiment
{
    partial class IndicatorManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btn_editIndicator = new DevComponents.DotNetBar.ButtonX();
            this.btn_addIndicator = new DevComponents.DotNetBar.ButtonX();
            this.panelObsolete = new DevComponents.DotNetBar.PanelEx();
            this.chk_isObsolete = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_isEffective = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_indicator = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.indicatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.className = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorDesc = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.isObsolete = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelObsolete.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_indicator)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1153, 149);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.panelEx4);
            this.groupPanel2.Controls.Add(this.panelObsolete);
            this.groupPanel2.Controls.Add(this.panelEx2);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.DrawTitleBox = false;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1153, 149);
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
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "指标筛选";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.btn_editIndicator);
            this.panelEx4.Controls.Add(this.btn_addIndicator);
            this.panelEx4.Location = new System.Drawing.Point(949, 4);
            this.panelEx4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(173, 101);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 2;
            // 
            // btn_editIndicator
            // 
            this.btn_editIndicator.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editIndicator.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editIndicator.Location = new System.Drawing.Point(33, 55);
            this.btn_editIndicator.Name = "btn_editIndicator";
            this.btn_editIndicator.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btn_editIndicator.Size = new System.Drawing.Size(105, 28);
            this.btn_editIndicator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editIndicator.TabIndex = 5;
            this.btn_editIndicator.Text = "编辑指标";
            this.btn_editIndicator.Click += new System.EventHandler(this.btn_editIndicator_Click);
            // 
            // btn_addIndicator
            // 
            this.btn_addIndicator.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addIndicator.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addIndicator.Location = new System.Drawing.Point(33, 14);
            this.btn_addIndicator.Name = "btn_addIndicator";
            this.btn_addIndicator.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btn_addIndicator.Size = new System.Drawing.Size(105, 28);
            this.btn_addIndicator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addIndicator.TabIndex = 4;
            this.btn_addIndicator.Text = "新增指标";
            this.btn_addIndicator.Click += new System.EventHandler(this.btn_addIndicator_Click);
            // 
            // panelObsolete
            // 
            this.panelObsolete.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelObsolete.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelObsolete.Controls.Add(this.chk_isObsolete);
            this.panelObsolete.Controls.Add(this.chk_isEffective);
            this.panelObsolete.Location = new System.Drawing.Point(770, 4);
            this.panelObsolete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelObsolete.Name = "panelObsolete";
            this.panelObsolete.Size = new System.Drawing.Size(173, 101);
            this.panelObsolete.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelObsolete.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelObsolete.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelObsolete.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelObsolete.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelObsolete.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelObsolete.Style.GradientAngle = 90;
            this.panelObsolete.TabIndex = 1;
            // 
            // chk_isObsolete
            // 
            // 
            // 
            // 
            this.chk_isObsolete.BackgroundStyle.Class = "";
            this.chk_isObsolete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_isObsolete.Checked = true;
            this.chk_isObsolete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_isObsolete.CheckValue = "Y";
            this.chk_isObsolete.Location = new System.Drawing.Point(28, 60);
            this.chk_isObsolete.Name = "chk_isObsolete";
            this.chk_isObsolete.Size = new System.Drawing.Size(127, 23);
            this.chk_isObsolete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_isObsolete.TabIndex = 1;
            this.chk_isObsolete.Tag = "";
            this.chk_isObsolete.Text = "已废弃";
            this.chk_isObsolete.CheckedChanged += new System.EventHandler(this.chk_valueChange);
            // 
            // chk_isEffective
            // 
            // 
            // 
            // 
            this.chk_isEffective.BackgroundStyle.Class = "";
            this.chk_isEffective.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_isEffective.Checked = true;
            this.chk_isEffective.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_isEffective.CheckValue = "Y";
            this.chk_isEffective.Location = new System.Drawing.Point(28, 19);
            this.chk_isEffective.Name = "chk_isEffective";
            this.chk_isEffective.Size = new System.Drawing.Size(127, 23);
            this.chk_isEffective.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_isEffective.TabIndex = 1;
            this.chk_isEffective.Tag = "";
            this.chk_isEffective.Text = "生效中";
            this.chk_isEffective.CheckedChanged += new System.EventHandler(this.chk_valueChange);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.tlp);
            this.panelEx2.Location = new System.Drawing.Point(25, 4);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(739, 101);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgv_indicator);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 149);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1153, 622);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "指标管理";
            // 
            // dgv_indicator
            // 
            this.dgv_indicator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_indicator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_indicator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indicatorId,
            this.classId,
            this.className,
            this.indicatorName,
            this.indicatorDesc,
            this.isObsolete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_indicator.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_indicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_indicator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_indicator.Location = new System.Drawing.Point(0, 0);
            this.dgv_indicator.MultiSelect = false;
            this.dgv_indicator.Name = "dgv_indicator";
            this.dgv_indicator.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_indicator.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_indicator.RowTemplate.Height = 27;
            this.dgv_indicator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_indicator.Size = new System.Drawing.Size(1147, 592);
            this.dgv_indicator.TabIndex = 0;
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp.Size = new System.Drawing.Size(739, 101);
            this.tlp.TabIndex = 4;
            // 
            // indicatorId
            // 
            this.indicatorId.DataPropertyName = "indicatorId";
            this.indicatorId.HeaderText = "indicatorId";
            this.indicatorId.Name = "indicatorId";
            this.indicatorId.ReadOnly = true;
            this.indicatorId.Visible = false;
            // 
            // classId
            // 
            this.classId.DataPropertyName = "classId";
            this.classId.HeaderText = "classId";
            this.classId.Name = "classId";
            this.classId.ReadOnly = true;
            this.classId.Visible = false;
            // 
            // className
            // 
            this.className.DataPropertyName = "className";
            this.className.FillWeight = 20F;
            this.className.HeaderText = "所属分类";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            // 
            // indicatorName
            // 
            this.indicatorName.DataPropertyName = "indicatorName";
            this.indicatorName.HeaderText = "指标名称";
            this.indicatorName.Name = "indicatorName";
            this.indicatorName.ReadOnly = true;
            // 
            // indicatorDesc
            // 
            this.indicatorDesc.DataPropertyName = "indicatorDesc";
            this.indicatorDesc.FillWeight = 150F;
            this.indicatorDesc.HeaderText = "指标说明";
            this.indicatorDesc.Name = "indicatorDesc";
            this.indicatorDesc.ReadOnly = true;
            // 
            // isObsolete
            // 
            this.isObsolete.DataPropertyName = "isObsolete";
            this.isObsolete.FillWeight = 20F;
            this.isObsolete.HeaderText = "是否废弃";
            this.isObsolete.Name = "isObsolete";
            this.isObsolete.ReadOnly = true;
            // 
            // IndicatorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 771);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IndicatorManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试指标项管理";
            this.Shown += new System.EventHandler(this.IndicatorManage_Shown);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelObsolete.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_indicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelObsolete;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_isObsolete;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_isEffective;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_indicator;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.ButtonX btn_addIndicator;
        private DevComponents.DotNetBar.ButtonX btn_editIndicator;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicatorId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn classId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn className;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorDesc;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn isObsolete;
    }
}