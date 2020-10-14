namespace AviationSafetyExperiment
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.endTime = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chartTaskClassify = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_taskState = new DevComponents.DotNetBar.LabelX();
            this.btn_chartReport = new DevComponents.DotNetBar.ButtonX();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTime)).BeginInit();
            this.SuspendLayout();
            // 
            // reportChart
            // 
            this.reportChart.BackColor = System.Drawing.Color.Transparent;
            this.reportChart.BackSecondaryColor = System.Drawing.Color.Black;
            this.reportChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.reportChart.BorderSkin.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 92F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 12F;
            this.reportChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 10F;
            legend1.Position.Width = 60F;
            legend1.Position.X = 25F;
            legend1.Position.Y = 90F;
            this.reportChart.Legends.Add(legend1);
            this.reportChart.Location = new System.Drawing.Point(215, 134);
            this.reportChart.Name = "reportChart";
            this.reportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.reportChart.Series.Add(series1);
            this.reportChart.Size = new System.Drawing.Size(468, 271);
            this.reportChart.TabIndex = 0;
            this.reportChart.Text = "chart1";
            this.reportChart.Visible = false;
            // 
            // startTime
            // 
            // 
            // 
            // 
            this.startTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.startTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.startTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.startTime.ButtonDropDown.Visible = true;
            this.startTime.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.startTime.IsPopupCalendarOpen = false;
            this.startTime.Location = new System.Drawing.Point(80, 24);
            // 
            // 
            // 
            this.startTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.startTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.startTime.MonthCalendar.BackgroundStyle.Class = "";
            this.startTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.startTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.startTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.startTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.startTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.startTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.startTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.startTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.startTime.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.startTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.startTime.MonthCalendar.DisplayMonth = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.startTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.startTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.startTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.startTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.startTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.startTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.startTime.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.startTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.startTime.MonthCalendar.TodayButtonVisible = true;
            this.startTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(175, 21);
            this.startTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.startTime.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(56, 18);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "起始时间";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(279, 27);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(56, 18);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "结束时间";
            // 
            // endTime
            // 
            // 
            // 
            // 
            this.endTime.BackgroundStyle.Class = "DateTimeInputBackground";
            this.endTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.endTime.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.endTime.ButtonDropDown.Visible = true;
            this.endTime.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.endTime.IsPopupCalendarOpen = false;
            this.endTime.Location = new System.Drawing.Point(344, 24);
            // 
            // 
            // 
            this.endTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.endTime.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.endTime.MonthCalendar.BackgroundStyle.Class = "";
            this.endTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.endTime.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.endTime.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.endTime.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.endTime.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.endTime.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.endTime.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.endTime.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.endTime.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.endTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.endTime.MonthCalendar.DisplayMonth = new System.DateTime(2020, 10, 1, 0, 0, 0, 0);
            this.endTime.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.endTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.endTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.endTime.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.endTime.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.endTime.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.endTime.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.endTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.endTime.MonthCalendar.TodayButtonVisible = true;
            this.endTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(175, 21);
            this.endTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.endTime.TabIndex = 4;
            // 
            // chartTaskClassify
            // 
            this.chartTaskClassify.DisplayMember = "Text";
            this.chartTaskClassify.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chartTaskClassify.FormattingEnabled = true;
            this.chartTaskClassify.ItemHeight = 17;
            this.chartTaskClassify.Items.AddRange(new object[] {
            this.comboItem1});
            this.chartTaskClassify.Location = new System.Drawing.Point(605, 23);
            this.chartTaskClassify.Name = "chartTaskClassify";
            this.chartTaskClassify.Size = new System.Drawing.Size(157, 23);
            this.chartTaskClassify.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chartTaskClassify.TabIndex = 8;
            // 
            // lbl_taskState
            // 
            this.lbl_taskState.AutoSize = true;
            // 
            // 
            // 
            this.lbl_taskState.BackgroundStyle.Class = "";
            this.lbl_taskState.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_taskState.Location = new System.Drawing.Point(540, 27);
            this.lbl_taskState.Name = "lbl_taskState";
            this.lbl_taskState.Size = new System.Drawing.Size(56, 18);
            this.lbl_taskState.TabIndex = 7;
            this.lbl_taskState.Text = "测试任务";
            // 
            // btn_chartReport
            // 
            this.btn_chartReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_chartReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_chartReport.Location = new System.Drawing.Point(785, 18);
            this.btn_chartReport.Name = "btn_chartReport";
            this.btn_chartReport.Size = new System.Drawing.Size(92, 33);
            this.btn_chartReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_chartReport.TabIndex = 9;
            this.btn_chartReport.Text = "图表生成";
            this.btn_chartReport.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "统计不同测试人员测试项数量";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 504);
            this.Controls.Add(this.btn_chartReport);
            this.Controls.Add(this.chartTaskClassify);
            this.Controls.Add(this.lbl_taskState);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.reportChart);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput startTime;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput endTime;
        private DevComponents.DotNetBar.Controls.ComboBoxEx chartTaskClassify;
        private DevComponents.DotNetBar.LabelX lbl_taskState;
        private DevComponents.DotNetBar.ButtonX btn_chartReport;
        private DevComponents.Editors.ComboItem comboItem1;
    }
}