namespace AviationSafetyExperiment
{
    partial class SupplementForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_alarmType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_alarmForm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ii_testCount = new DevComponents.Editors.IntegerInput();
            this.ii_alarmCount = new DevComponents.Editors.IntegerInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.ii_omitCount = new DevComponents.Editors.IntegerInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.ii_misinformationCount = new DevComponents.Editors.IntegerInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.ii_usableCount = new DevComponents.Editors.IntegerInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btn_submit = new DevComponents.DotNetBar.ButtonX();
            this.alarmSupplementPan = new AviationSafetyExperiment.UserControls.AlarmSupplementPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ii_testCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_alarmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_omitCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_misinformationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_usableCount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(13, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "报警类型";
            this.labelX1.Visible = false;
            // 
            // txt_alarmType
            // 
            // 
            // 
            // 
            this.txt_alarmType.Border.Class = "TextBoxBorder";
            this.txt_alarmType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_alarmType.Location = new System.Drawing.Point(85, 10);
            this.txt_alarmType.Name = "txt_alarmType";
            this.txt_alarmType.Size = new System.Drawing.Size(318, 23);
            this.txt_alarmType.TabIndex = 1;
            this.txt_alarmType.Visible = false;
            // 
            // txt_alarmForm
            // 
            // 
            // 
            // 
            this.txt_alarmForm.Border.Class = "TextBoxBorder";
            this.txt_alarmForm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_alarmForm.Location = new System.Drawing.Point(85, 58);
            this.txt_alarmForm.Name = "txt_alarmForm";
            this.txt_alarmForm.Size = new System.Drawing.Size(318, 23);
            this.txt_alarmForm.TabIndex = 3;
            this.txt_alarmForm.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(13, 62);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 20);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "报警形式";
            this.labelX2.Visible = false;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(13, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(56, 20);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "测试总数";
            // 
            // ii_testCount
            // 
            // 
            // 
            // 
            this.ii_testCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_testCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_testCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_testCount.Location = new System.Drawing.Point(85, 10);
            this.ii_testCount.Name = "ii_testCount";
            this.ii_testCount.Size = new System.Drawing.Size(80, 23);
            this.ii_testCount.TabIndex = 5;
            // 
            // ii_alarmCount
            // 
            // 
            // 
            // 
            this.ii_alarmCount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ii_alarmCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ii_alarmCount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ii_alarmCount.Location = new System.Drawing.Point(323, 10);
            this.ii_alarmCount.Name = "ii_alarmCount";
            this.ii_alarmCount.Size = new System.Drawing.Size(80, 23);
            this.ii_alarmCount.TabIndex = 7;
            this.ii_alarmCount.MouseLeave += new System.EventHandler(this.ii_alarmCount_MouseLeave);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(220, 11);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(81, 20);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "测试报警数量";
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
            this.ii_omitCount.Location = new System.Drawing.Point(85, 59);
            this.ii_omitCount.Name = "ii_omitCount";
            this.ii_omitCount.Size = new System.Drawing.Size(80, 23);
            this.ii_omitCount.TabIndex = 9;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(13, 60);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(56, 20);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "漏报数量";
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
            this.ii_misinformationCount.Location = new System.Drawing.Point(323, 59);
            this.ii_misinformationCount.Name = "ii_misinformationCount";
            this.ii_misinformationCount.Size = new System.Drawing.Size(80, 23);
            this.ii_misinformationCount.TabIndex = 11;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(251, 60);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(56, 20);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "误报数量";
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
            this.ii_usableCount.Location = new System.Drawing.Point(85, 108);
            this.ii_usableCount.Name = "ii_usableCount";
            this.ii_usableCount.Size = new System.Drawing.Size(80, 23);
            this.ii_usableCount.TabIndex = 13;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(13, 109);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(56, 20);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "正常数量";
            // 
            // btn_submit
            // 
            this.btn_submit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_submit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_submit.Location = new System.Drawing.Point(159, 416);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(100, 44);
            this.btn_submit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "确 定";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // alarmSupplementPan
            // 
            this.alarmSupplementPan.Location = new System.Drawing.Point(13, 138);
            this.alarmSupplementPan.Margin = new System.Windows.Forms.Padding(0);
            this.alarmSupplementPan.Name = "alarmSupplementPan";
            this.alarmSupplementPan.Size = new System.Drawing.Size(406, 222);
            this.alarmSupplementPan.TabIndex = 15;
            // 
            // SupplementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 472);
            this.Controls.Add(this.alarmSupplementPan);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.ii_usableCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.ii_misinformationCount);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.ii_omitCount);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.ii_alarmCount);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.ii_testCount);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txt_alarmForm);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_alarmType);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SupplementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "漏报补报录入";
            this.Shown += new System.EventHandler(this.SupplementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ii_testCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_alarmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_omitCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_misinformationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ii_usableCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_alarmType;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_alarmForm;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput ii_testCount;
        private DevComponents.Editors.IntegerInput ii_alarmCount;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput ii_omitCount;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.IntegerInput ii_misinformationCount;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.IntegerInput ii_usableCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btn_submit;
        private UserControls.AlarmSupplementPanel alarmSupplementPan;
    }
}