namespace AviationSafetyExperiment
{
    partial class IndicatorEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndicatorEdit));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cbb_subDetection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cbb_detection = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cbb_class = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chk_isObsolete = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.txt_indicatorDesc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_indicatorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Your error message here.");
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.txt_indicatorInstr = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cbb_subDetection);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.cbb_detection);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.cbb_class);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.chk_isObsolete);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(671, 94);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // cbb_subDetection
            // 
            this.cbb_subDetection.DisplayMember = "Text";
            this.cbb_subDetection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_subDetection.FormattingEnabled = true;
            this.cbb_subDetection.ItemHeight = 21;
            this.cbb_subDetection.Location = new System.Drawing.Point(437, 46);
            this.cbb_subDetection.Name = "cbb_subDetection";
            this.cbb_subDetection.Size = new System.Drawing.Size(198, 27);
            this.cbb_subDetection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_subDetection.TabIndex = 10;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(344, 46);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 31);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "检测分项";
            // 
            // cbb_detection
            // 
            this.cbb_detection.DisplayMember = "Text";
            this.cbb_detection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_detection.FormattingEnabled = true;
            this.cbb_detection.ItemHeight = 21;
            this.cbb_detection.Location = new System.Drawing.Point(122, 46);
            this.cbb_detection.Name = "cbb_detection";
            this.cbb_detection.Size = new System.Drawing.Size(198, 27);
            this.cbb_detection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_detection.TabIndex = 8;
            this.cbb_detection.SelectedIndexChanged += new System.EventHandler(this.cbb_detection_SelectedIndexChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(29, 46);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(84, 31);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "检测内容";
            // 
            // cbb_class
            // 
            this.cbb_class.DisplayMember = "Text";
            this.cbb_class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_class.FormattingEnabled = true;
            this.cbb_class.ItemHeight = 21;
            this.cbb_class.Location = new System.Drawing.Point(122, 13);
            this.cbb_class.Name = "cbb_class";
            this.cbb_class.Size = new System.Drawing.Size(198, 27);
            this.cbb_class.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_class.TabIndex = 6;
            this.cbb_class.SelectedIndexChanged += new System.EventHandler(this.cbb_class_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(29, 13);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(84, 31);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "所属分类";
            // 
            // chk_isObsolete
            // 
            // 
            // 
            // 
            this.chk_isObsolete.BackgroundStyle.Class = "";
            this.chk_isObsolete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chk_isObsolete.Location = new System.Drawing.Point(553, 13);
            this.chk_isObsolete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_isObsolete.Name = "chk_isObsolete";
            this.chk_isObsolete.Size = new System.Drawing.Size(82, 31);
            this.chk_isObsolete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chk_isObsolete.TabIndex = 4;
            this.chk_isObsolete.Text = "已废弃";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txt_indicatorInstr);
            this.panelEx2.Controls.Add(this.labelX6);
            this.panelEx2.Controls.Add(this.btn_save);
            this.panelEx2.Controls.Add(this.txt_indicatorDesc);
            this.panelEx2.Controls.Add(this.txt_indicatorName);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 94);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(671, 508);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(289, 464);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 31);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "保 存";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_indicatorDesc
            // 
            // 
            // 
            // 
            this.txt_indicatorDesc.Border.Class = "TextBoxBorder";
            this.txt_indicatorDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_indicatorDesc.Location = new System.Drawing.Point(122, 79);
            this.txt_indicatorDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_indicatorDesc.Multiline = true;
            this.txt_indicatorDesc.Name = "txt_indicatorDesc";
            this.txt_indicatorDesc.Size = new System.Drawing.Size(513, 180);
            this.txt_indicatorDesc.TabIndex = 3;
            this.superValidator1.SetValidator1(this.txt_indicatorDesc, this.requiredFieldValidator2);
            // 
            // txt_indicatorName
            // 
            // 
            // 
            // 
            this.txt_indicatorName.Border.Class = "TextBoxBorder";
            this.txt_indicatorName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_indicatorName.Location = new System.Drawing.Point(122, 20);
            this.txt_indicatorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_indicatorName.Name = "txt_indicatorName";
            this.txt_indicatorName.Size = new System.Drawing.Size(513, 32);
            this.txt_indicatorName.TabIndex = 2;
            this.superValidator1.SetValidator1(this.txt_indicatorName, this.requiredFieldValidator1);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(29, 75);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(84, 31);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "指标说明";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(29, 24);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(84, 31);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "指标名称";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "Your error message here.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // txt_indicatorInstr
            // 
            // 
            // 
            // 
            this.txt_indicatorInstr.Border.Class = "TextBoxBorder";
            this.txt_indicatorInstr.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_indicatorInstr.Location = new System.Drawing.Point(122, 267);
            this.txt_indicatorInstr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_indicatorInstr.Multiline = true;
            this.txt_indicatorInstr.Name = "txt_indicatorInstr";
            this.txt_indicatorInstr.Size = new System.Drawing.Size(513, 180);
            this.txt_indicatorInstr.TabIndex = 7;
            this.superValidator1.SetValidator1(this.txt_indicatorInstr, this.requiredFieldValidator2);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(29, 263);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(84, 31);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "操作说明";
            // 
            // IndicatorEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(671, 602);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "IndicatorEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "指标编辑";
            this.Shown += new System.EventHandler(this.IndicatorEdit_Shown);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_indicatorDesc;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_indicatorName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.Controls.CheckBoxX chk_isObsolete;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_class;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_subDetection;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_detection;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_indicatorInstr;
        private DevComponents.DotNetBar.LabelX labelX6;
    }
}