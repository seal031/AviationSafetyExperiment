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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tree_detection = new DevComponents.AdvTree.AdvTree();
            this.rootNode = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btn_saveTree = new DevComponents.DotNetBar.ButtonX();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_indicator = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.indicatorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.className = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.detectionId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.detectionName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.subDetectionId = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.subDetectionName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorName = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.indicatorDesc = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.isObsolete = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btn_editIndicator = new DevComponents.DotNetBar.ButtonX();
            this.btn_addIndicator = new DevComponents.DotNetBar.ButtonX();
            this.panelObsolete = new DevComponents.DotNetBar.PanelEx();
            this.chk_isObsolete = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chk_isEffective = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControl2 = new DevComponents.DotNetBar.SuperTabControl();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.sti_unselected = new DevComponents.DotNetBar.SuperTabItem();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_addNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.its = new AviationSafetyExperiment.UserControls.IndicatorTemplateSelecter();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tree_detection)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_indicator)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelObsolete.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.HorizontalText = false;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 1;
            this.superTabControl1.Size = new System.Drawing.Size(1215, 771);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2,
            this.superTabItem3});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.its);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(33, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(1182, 771);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "检测指标模板";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.tree_detection);
            this.superTabControlPanel1.Controls.Add(this.panelEx3);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(33, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(1182, 771);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // tree_detection
            // 
            this.tree_detection.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.tree_detection.AllowDrop = true;
            this.tree_detection.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.tree_detection.BackgroundStyle.Class = "TreeBorderKey";
            this.tree_detection.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tree_detection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_detection.Location = new System.Drawing.Point(0, 0);
            this.tree_detection.Name = "tree_detection";
            this.tree_detection.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.rootNode});
            this.tree_detection.NodesConnector = this.nodeConnector1;
            this.tree_detection.NodeStyle = this.elementStyle1;
            this.tree_detection.PathSeparator = ";";
            this.tree_detection.Size = new System.Drawing.Size(1182, 736);
            this.tree_detection.Styles.Add(this.elementStyle1);
            this.tree_detection.TabIndex = 2;
            // 
            // rootNode
            // 
            this.rootNode.Expanded = true;
            this.rootNode.Name = "rootNode";
            this.rootNode.Text = "全部";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_saveTree);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 736);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1182, 35);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // btn_saveTree
            // 
            this.btn_saveTree.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_saveTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveTree.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_saveTree.Location = new System.Drawing.Point(550, 7);
            this.btn_saveTree.Name = "btn_saveTree";
            this.btn_saveTree.Size = new System.Drawing.Size(75, 23);
            this.btn_saveTree.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_saveTree.TabIndex = 0;
            this.btn_saveTree.Text = "保 存";
            this.btn_saveTree.Click += new System.EventHandler(this.btn_saveTree_Click);
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "检测内容/分项";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.groupPanel1);
            this.superTabControlPanel2.Controls.Add(this.panelEx1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(33, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(1182, 771);
            this.superTabControlPanel2.TabIndex = 2;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
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
            this.groupPanel1.Size = new System.Drawing.Size(1182, 622);
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
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "指标管理";
            // 
            // dgv_indicator
            // 
            this.dgv_indicator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_indicator.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_indicator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_indicator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indicatorId,
            this.classId,
            this.className,
            this.detectionId,
            this.detectionName,
            this.subDetectionId,
            this.subDetectionName,
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
            this.dgv_indicator.Size = new System.Drawing.Size(1176, 592);
            this.dgv_indicator.TabIndex = 0;
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
            this.classId.TextAlignment = System.Drawing.StringAlignment.Center;
            this.classId.Visible = false;
            // 
            // className
            // 
            this.className.DataPropertyName = "className";
            this.className.FillWeight = 20F;
            this.className.HeaderText = "所属分类";
            this.className.Name = "className";
            this.className.ReadOnly = true;
            this.className.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // detectionId
            // 
            this.detectionId.DataPropertyName = "detectionId";
            this.detectionId.HeaderText = "detectionId";
            this.detectionId.Name = "detectionId";
            this.detectionId.ReadOnly = true;
            this.detectionId.TextAlignment = System.Drawing.StringAlignment.Center;
            this.detectionId.Visible = false;
            // 
            // detectionName
            // 
            this.detectionName.DataPropertyName = "detectionName";
            this.detectionName.FillWeight = 20F;
            this.detectionName.HeaderText = "检测内容";
            this.detectionName.Name = "detectionName";
            this.detectionName.ReadOnly = true;
            this.detectionName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // subDetectionId
            // 
            this.subDetectionId.DataPropertyName = "subDetectionId";
            this.subDetectionId.HeaderText = "subDetectionId";
            this.subDetectionId.Name = "subDetectionId";
            this.subDetectionId.ReadOnly = true;
            this.subDetectionId.TextAlignment = System.Drawing.StringAlignment.Center;
            this.subDetectionId.Visible = false;
            // 
            // subDetectionName
            // 
            this.subDetectionName.DataPropertyName = "subDetectionName";
            this.subDetectionName.FillWeight = 30F;
            this.subDetectionName.HeaderText = "检测分项";
            this.subDetectionName.Name = "subDetectionName";
            this.subDetectionName.ReadOnly = true;
            this.subDetectionName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // indicatorName
            // 
            this.indicatorName.DataPropertyName = "indicatorName";
            this.indicatorName.FillWeight = 50F;
            this.indicatorName.HeaderText = "指标名称";
            this.indicatorName.Name = "indicatorName";
            this.indicatorName.ReadOnly = true;
            this.indicatorName.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // indicatorDesc
            // 
            this.indicatorDesc.DataPropertyName = "indicatorDesc";
            this.indicatorDesc.FillWeight = 150F;
            this.indicatorDesc.HeaderText = "指标说明";
            this.indicatorDesc.Name = "indicatorDesc";
            this.indicatorDesc.ReadOnly = true;
            this.indicatorDesc.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // isObsolete
            // 
            this.isObsolete.DataPropertyName = "isObsolete";
            this.isObsolete.FillWeight = 20F;
            this.isObsolete.HeaderText = "是否废弃";
            this.isObsolete.Name = "isObsolete";
            this.isObsolete.ReadOnly = true;
            this.isObsolete.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.panelEx1.Size = new System.Drawing.Size(1182, 149);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
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
            this.groupPanel2.Size = new System.Drawing.Size(1182, 149);
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
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "检测指标明细";
            // 
            // superTabControl2
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl2.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl2.ControlBox.MenuBox.Name = "";
            this.superTabControl2.ControlBox.Name = "";
            this.superTabControl2.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl2.ControlBox.MenuBox,
            this.superTabControl2.ControlBox.CloseBox});
            this.superTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl2.Location = new System.Drawing.Point(0, 0);
            this.superTabControl2.Name = "superTabControl2";
            this.superTabControl2.ReorderTabsEnabled = true;
            this.superTabControl2.SelectedTabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl2.SelectedTabIndex = 0;
            this.superTabControl2.Size = new System.Drawing.Size(1182, 771);
            this.superTabControl2.TabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl2.TabIndex = 0;
            this.superTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            // 
            // labelItem1
            // 
            this.labelItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "快捷操作提示：双击指标可切换已选/待选状态";
            // 
            // sti_unselected
            // 
            this.sti_unselected.GlobalItem = false;
            this.sti_unselected.Name = "sti_unselected";
            this.sti_unselected.Text = "待选指标";
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_addNew,
            this.tsmi_edit});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(139, 52);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // tsmi_addNew
            // 
            this.tsmi_addNew.Name = "tsmi_addNew";
            this.tsmi_addNew.Size = new System.Drawing.Size(138, 24);
            this.tsmi_addNew.Text = "新增子项";
            this.tsmi_addNew.Click += new System.EventHandler(this.tsmi_addNew_Click);
            // 
            // tsmi_edit
            // 
            this.tsmi_edit.Name = "tsmi_edit";
            this.tsmi_edit.Size = new System.Drawing.Size(138, 24);
            this.tsmi_edit.Text = "修改本项";
            this.tsmi_edit.Click += new System.EventHandler(this.tsmi_edit_Click);
            // 
            // its
            // 
            this.its.Dock = System.Windows.Forms.DockStyle.Fill;
            this.its.Location = new System.Drawing.Point(0, 0);
            this.its.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.its.Name = "its";
            this.its.Size = new System.Drawing.Size(1182, 771);
            this.its.TabIndex = 0;
            // 
            // IndicatorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 771);
            this.Controls.Add(this.superTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IndicatorManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试指标项管理";
            this.Shown += new System.EventHandler(this.IndicatorManage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tree_detection)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_indicator)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelObsolete.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl2)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_indicator;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.ButtonX btn_editIndicator;
        private DevComponents.DotNetBar.ButtonX btn_addIndicator;
        private DevComponents.DotNetBar.PanelEx panelObsolete;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_isObsolete;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_isEffective;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmi_addNew;
        private System.Windows.Forms.ToolStripMenuItem tsmi_edit;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX btn_saveTree;
        private DevComponents.AdvTree.AdvTree tree_detection;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.Node rootNode;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicatorId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn classId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn className;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn detectionId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn detectionName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn subDetectionId;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn subDetectionName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorName;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn indicatorDesc;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn isObsolete;
        private DevComponents.DotNetBar.SuperTabControl superTabControl2;
        private DevComponents.DotNetBar.SuperTabItem sti_unselected;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private UserControls.IndicatorTemplateSelecter its;
    }
}