namespace AviationSafetyExperiment.UserControls
{
    partial class PagingPanel
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
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.ccb_pageSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.btn_head = new DevComponents.DotNetBar.ButtonItem();
            this.btn_pre = new DevComponents.DotNetBar.ButtonItem();
            this.lbl_currentPage = new DevComponents.DotNetBar.LabelItem();
            this.btn_next = new DevComponents.DotNetBar.ButtonItem();
            this.btn_tail = new DevComponents.DotNetBar.ButtonItem();
            this.lbl_detail = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.ribbonBar1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1238, 30);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonBar1.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.ccb_pageSize,
            this.btn_head,
            this.btn_pre,
            this.lbl_currentPage,
            this.btn_next,
            this.btn_tail,
            this.lbl_detail,
            this.labelItem2});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1238, 30);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.TitleVisible = false;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "每页条数";
            // 
            // ccb_pageSize
            // 
            this.ccb_pageSize.DropDownHeight = 106;
            this.ccb_pageSize.ItemHeight = 21;
            this.ccb_pageSize.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.ccb_pageSize.Name = "ccb_pageSize";
            this.ccb_pageSize.SelectedIndexChanged += new System.EventHandler(this.ccb_pageSize_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "10";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "20";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "50";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "100";
            // 
            // btn_head
            // 
            this.btn_head.Image = global::AviationSafetyExperiment.Properties.Resources.s_27;
            this.btn_head.Name = "btn_head";
            this.btn_head.SubItemsExpandWidth = 14;
            this.btn_head.Click += new System.EventHandler(this.btn_head_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Image = global::AviationSafetyExperiment.Properties.Resources.s_20;
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.SubItemsExpandWidth = 14;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // lbl_currentPage
            // 
            this.lbl_currentPage.Name = "lbl_currentPage";
            this.lbl_currentPage.Text = "   ";
            // 
            // btn_next
            // 
            this.btn_next.Image = global::AviationSafetyExperiment.Properties.Resources.s_19;
            this.btn_next.Name = "btn_next";
            this.btn_next.SubItemsExpandWidth = 14;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_tail
            // 
            this.btn_tail.Image = global::AviationSafetyExperiment.Properties.Resources.s_28;
            this.btn_tail.Name = "btn_tail";
            this.btn_tail.SubItemsExpandWidth = 14;
            this.btn_tail.Click += new System.EventHandler(this.btn_tail_Click);
            // 
            // lbl_detail
            // 
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.Text = "    ";
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "    ";
            // 
            // PagingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagingPanel";
            this.Size = new System.Drawing.Size(1238, 30);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ComboBoxItem ccb_pageSize;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.ButtonItem btn_head;
        private DevComponents.DotNetBar.ButtonItem btn_pre;
        private DevComponents.DotNetBar.LabelItem lbl_currentPage;
        private DevComponents.DotNetBar.ButtonItem btn_next;
        private DevComponents.DotNetBar.ButtonItem btn_tail;
        private DevComponents.DotNetBar.LabelItem lbl_detail;
        private DevComponents.DotNetBar.LabelItem labelItem2;
    }
}
