﻿namespace AviationSafetyExperiment.UserControls
{
    partial class TaskChartSlidePanel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.chartClassify = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMonthCountTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.microChartItem1 = new DevComponents.DotNetBar.MicroChartItem();
            this.itemPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartClassify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthCountTask)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.chartClassify);
            this.itemPanel1.Controls.Add(this.chartMonthCountTask);
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.microChartItem1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(300, 500);
            this.itemPanel1.TabIndex = 0;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // chartClassify
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 9F;
            this.chartClassify.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 12F;
            legend1.Position.Width = 30.13699F;
            legend1.Position.X = 38F;
            legend1.Position.Y = 88F;
            this.chartClassify.Legends.Add(legend1);
            this.chartClassify.Location = new System.Drawing.Point(4, 243);
            this.chartClassify.Name = "chartClassify";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartClassify.Series.Add(series1);
            this.chartClassify.Size = new System.Drawing.Size(293, 196);
            this.chartClassify.TabIndex = 1;
            this.chartClassify.Text = "chart1";
            // 
            // chartMonthCountTask
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 80F;
            chartArea2.Position.Width = 100F;
            chartArea2.Position.Y = 9F;
            this.chartMonthCountTask.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 12F;
            legend2.Position.Width = 30.13699F;
            legend2.Position.X = 38F;
            legend2.Position.Y = 88F;
            this.chartMonthCountTask.Legends.Add(legend2);
            this.chartMonthCountTask.Location = new System.Drawing.Point(4, 30);
            this.chartMonthCountTask.Name = "chartMonthCountTask";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMonthCountTask.Series.Add(series2);
            this.chartMonthCountTask.Size = new System.Drawing.Size(293, 196);
            this.chartMonthCountTask.TabIndex = 0;
            this.chartMonthCountTask.Text = "chart1";
            // 
            // microChartItem1
            // 
            this.microChartItem1.Name = "microChartItem1";
            // 
            // TaskChartSlidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TaskChartSlidePanel";
            this.Size = new System.Drawing.Size(300, 500);
            this.itemPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartClassify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthCountTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.MicroChartItem microChartItem1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthCountTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClassify;
    }
}
