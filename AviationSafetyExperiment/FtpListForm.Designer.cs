namespace AviationSafetyExperiment
{
    partial class FtpListForm
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
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_openFileDialog = new DevComponents.DotNetBar.ButtonX();
            this.ip = new DevComponents.DotNetBar.ItemPanel();
            this.ic_header = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.ii_usableCount = new DevComponents.Editors.IntegerInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.ii_misinformationCount = new DevComponents.Editors.IntegerInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ii_omitCount = new DevComponents.Editors.IntegerInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ii_alarmCount = new DevComponents.Editors.IntegerInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.ii_testCount = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_alarmForm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_alarmType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ii_usableCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_misinformationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_omitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_alarmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_testCount)).BeginInit();
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
            this.superTabControl1.Controls.Add(this.superTabControlPanel2);
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 1;
            this.superTabControl1.Size = new System.Drawing.Size(415, 374);
            this.superTabControl1.TabFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1,
            this.superTabItem2});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "附件管理";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.panelEx1);
            this.superTabControlPanel1.Controls.Add(this.ip);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 34);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(415, 340);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.superTabControlPanel2;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "误报漏报";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.ii_usableCount);
            this.superTabControlPanel2.Controls.Add(this.labelX7);
            this.superTabControlPanel2.Controls.Add(this.ii_misinformationCount);
            this.superTabControlPanel2.Controls.Add(this.labelX6);
            this.superTabControlPanel2.Controls.Add(this.ii_omitCount);
            this.superTabControlPanel2.Controls.Add(this.labelX5);
            this.superTabControlPanel2.Controls.Add(this.ii_alarmCount);
            this.superTabControlPanel2.Controls.Add(this.labelX4);
            this.superTabControlPanel2.Controls.Add(this.ii_testCount);
            this.superTabControlPanel2.Controls.Add(this.labelX3);
            this.superTabControlPanel2.Controls.Add(this.txt_alarmForm);
            this.superTabControlPanel2.Controls.Add(this.labelX2);
            this.superTabControlPanel2.Controls.Add(this.txt_alarmType);
            this.superTabControlPanel2.Controls.Add(this.labelX1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 34);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(415, 340);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.superTabItem2;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Width = 240;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.Name = "itemContainer2";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_save);
            this.panelEx1.Controls.Add(this.btn_openFileDialog);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 280);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(415, 60);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(233, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 40);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "确 定";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_openFileDialog
            // 
            this.btn_openFileDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_openFileDialog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_openFileDialog.Location = new System.Drawing.Point(93, 10);
            this.btn_openFileDialog.Name = "btn_openFileDialog";
            this.btn_openFileDialog.Size = new System.Drawing.Size(80, 40);
            this.btn_openFileDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_openFileDialog.TabIndex = 0;
            this.btn_openFileDialog.Text = "浏览文件";
            this.btn_openFileDialog.Click += new System.EventHandler(this.btn_openFileDialog_Click);
            // 
            // ip
            // 
            // 
            // 
            // 
            this.ip.BackgroundStyle.Class = "ItemPanel";
            this.ip.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ip.ContainerControlProcessDialogKey = true;
            this.ip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ip.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ic_header});
            this.ip.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ip.Location = new System.Drawing.Point(0, 0);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(415, 340);
            this.ip.TabIndex = 4;
            this.ip.Text = "itemPanel1";
            // 
            // ic_header
            // 
            // 
            // 
            // 
            this.ic_header.BackgroundStyle.Class = "";
            this.ic_header.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ic_header.Name = "ic_header";
            this.ic_header.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.labelItem3,
            this.labelItem4});
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "文件";
            this.labelItem2.Width = 250;
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "进度";
            this.labelItem3.Width = 120;
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "操作";
            // 
            // ofd
            // 
            this.ofd.Filter = "所有文件(*.*)|*.*";
            this.ofd.Multiselect = true;
            this.ofd.Title = "选择附件";
            // 
            // ii_usableCount
            // 
            // 
            // 
            // 
            this.ii_usableCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_usableCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_usableCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_usableCount.Enabled = false;
            this.ii_usableCount.Location = new System.Drawing.Point(84, 224);
            this.ii_usableCount.Name = "ii_usableCount";
            this.ii_usableCount.Size = new System.Drawing.Size(80, 27);
            this.ii_usableCount.TabIndex = 27;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(12, 225);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(69, 24);
            this.labelX7.TabIndex = 26;
            this.labelX7.Text = "正常数量";
            // 
            // ii_misinformationCount
            // 
            // 
            // 
            // 
            this.ii_misinformationCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_misinformationCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_misinformationCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_misinformationCount.Enabled = false;
            this.ii_misinformationCount.Location = new System.Drawing.Point(322, 175);
            this.ii_misinformationCount.Name = "ii_misinformationCount";
            this.ii_misinformationCount.Size = new System.Drawing.Size(80, 27);
            this.ii_misinformationCount.TabIndex = 25;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(250, 176);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(69, 24);
            this.labelX6.TabIndex = 24;
            this.labelX6.Text = "误报数量";
            // 
            // ii_omitCount
            // 
            // 
            // 
            // 
            this.ii_omitCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_omitCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_omitCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_omitCount.Enabled = false;
            this.ii_omitCount.Location = new System.Drawing.Point(84, 175);
            this.ii_omitCount.Name = "ii_omitCount";
            this.ii_omitCount.Size = new System.Drawing.Size(80, 27);
            this.ii_omitCount.TabIndex = 23;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 176);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(69, 24);
            this.labelX5.TabIndex = 22;
            this.labelX5.Text = "漏报数量";
            // 
            // ii_alarmCount
            // 
            // 
            // 
            // 
            this.ii_alarmCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_alarmCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_alarmCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_alarmCount.Enabled = false;
            this.ii_alarmCount.Location = new System.Drawing.Point(322, 126);
            this.ii_alarmCount.Name = "ii_alarmCount";
            this.ii_alarmCount.Size = new System.Drawing.Size(80, 27);
            this.ii_alarmCount.TabIndex = 21;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(219, 127);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 24);
            this.labelX4.TabIndex = 20;
            this.labelX4.Text = "测试报警数量";
            // 
            // ii_testCount
            // 
            // 
            // 
            // 
            this.ii_testCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_testCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_testCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_testCount.Enabled = false;
            this.ii_testCount.Location = new System.Drawing.Point(84, 126);
            this.ii_testCount.Name = "ii_testCount";
            this.ii_testCount.Size = new System.Drawing.Size(80, 27);
            this.ii_testCount.TabIndex = 19;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 127);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(69, 24);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "测试总数";
            // 
            // txt_alarmForm
            // 
            // 
            // 
            // 
            this.txt_alarmForm.Border.Class = "TextBoxBorder";
            this.txt_alarmForm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_alarmForm.Enabled = false;
            this.txt_alarmForm.Location = new System.Drawing.Point(84, 74);
            this.txt_alarmForm.Name = "txt_alarmForm";
            this.txt_alarmForm.Size = new System.Drawing.Size(318, 32);
            this.txt_alarmForm.TabIndex = 17;
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
            this.labelX2.Location = new System.Drawing.Point(12, 78);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(69, 24);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "报警形式";
            // 
            // txt_alarmType
            // 
            // 
            // 
            // 
            this.txt_alarmType.Border.Class = "TextBoxBorder";
            this.txt_alarmType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_alarmType.Enabled = false;
            this.txt_alarmType.Location = new System.Drawing.Point(84, 26);
            this.txt_alarmType.Name = "txt_alarmType";
            this.txt_alarmType.Size = new System.Drawing.Size(318, 32);
            this.txt_alarmType.TabIndex = 15;
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
            this.labelX1.Location = new System.Drawing.Point(12, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 24);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "报警类型";
            // 
            // FtpListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 374);
            this.Controls.Add(this.superTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FtpListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "附件及补漏报管理";
            this.Shown += new System.EventHandler(this.FtpListForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel2.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ii_usableCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_misinformationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_omitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_alarmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_testCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_openFileDialog;
        private DevComponents.DotNetBar.ItemPanel ip;
        private DevComponents.DotNetBar.ItemContainer ic_header;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private DevComponents.Editors.IntegerInput ii_usableCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.IntegerInput ii_misinformationCount;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.IntegerInput ii_omitCount;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.IntegerInput ii_alarmCount;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput ii_testCount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_alarmForm;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_alarmType;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}