using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    public partial class ChartForm : Office2007Form
    {
        private int taskInfoId; 
        public ChartForm()
        {
            InitializeComponent();
            this.taskInfoId = 51;
        }
        public ChartForm(int taskID)
        {
            InitializeComponent();
            this.taskInfoId = taskID;
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(194, 217, 247);
            List<Tb_taskResult> resultList = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId).ToList();
            int maxRound = 0;
            try
            {
                maxRound = resultList.Max(x => x.taskRound);
            }
            catch (Exception ex)
            {
            }
            reportChart.Series.Clear();
            List<string> xAxis = new List<string>();
            List<int> yAxis = new List<int>();
            for (int i = 1; i <= maxRound; i++)
            {
                xAxis.Clear();
                yAxis.Clear();
                string seriesName = string.Format("轮次{0}", i);
                reportChart.Series.Add(seriesName);
                reportChart.Series[seriesName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                reportChart.Series[seriesName].IsValueShownAsLabel = true;
                if (i == 1)
                {
                    reportChart.Series[seriesName].Color = Color.SkyBlue;
                }
                else if (i == 2)
                {
                    reportChart.Series[seriesName].Color = Color.DeepSkyBlue;
                }
                else if (i == 3)
                {
                    reportChart.Series[seriesName].Color = Color.SlateGray;
                }
                else if (i == 4)
                {
                    reportChart.Series[seriesName].Color = Color.Lavender;
                }
                //查询该轮次的最大步骤
                int maxStep = 0;
                List<Tb_taskResult> result = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId && t.taskRound  == i).ToList();
                try
                {
                    maxStep = result.Max(x => x.taskStep);
                }
                catch (Exception ex)
                {
                }
                xAxis.Add("最大步骤");
                yAxis.Add(maxStep);
                reportChart.Series[seriesName].Points.DataBindXY(xAxis, yAxis);
                //reportChart.Series[seriesName].Points[0].wi
            }
            string title = "轮次的最大步骤";
            reportChart.Titles.Add(title);
            reportChart.Titles[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;

            

            reportChart.ChartAreas[0].AxisY.Maximum = 10;//设置Y轴最大值
            reportChart.ChartAreas[0].AxisY.Minimum = 0; //设置Y轴最小值
            //reportChart.ChartAreas[0].Position.Width = 100;
        }
    }
}
