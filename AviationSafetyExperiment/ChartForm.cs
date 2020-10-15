using AviationSafetyExperiment.Db.DAO;
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
        List<string> xAxis = new List<string>();
        List<int> yAxis = new List<int>();
        public ChartForm()
        {
            InitializeComponent();
            //this.taskInfoId = 51;
        }
        public ChartForm(int taskID)
        {
            InitializeComponent();
            this.taskInfoId = taskID;
        }
        private void Chart_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(194, 217, 247);
            //List<Tb_taskResult> resultList = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId).ToList();
            //int maxRound = 0;
            //try
            //{
            //    maxRound = resultList.Max(x => x.taskRound);
            //}
            //catch (Exception ex)
            //{
            //}
            //reportChart.Series.Clear();
            //List<string> xAxis = new List<string>();
            //List<int> yAxis = new List<int>();
            //for (int i = 1; i <= maxRound; i++)
            //{
            //    xAxis.Clear();
            //    yAxis.Clear();
            //    string seriesName = string.Format("轮次{0}", i);
            //    reportChart.Series.Add(seriesName);
            //    reportChart.Series[seriesName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //    reportChart.Series[seriesName].IsValueShownAsLabel = true;
            //    if (i == 1)
            //    {
            //        reportChart.Series[seriesName].Color = Color.SkyBlue;
            //    }
            //    else if (i == 2)
            //    {
            //        reportChart.Series[seriesName].Color = Color.DeepSkyBlue;
            //    }
            //    else if (i == 3)
            //    {
            //        reportChart.Series[seriesName].Color = Color.SlateGray;
            //    }
            //    else if (i == 4)
            //    {
            //        reportChart.Series[seriesName].Color = Color.Lavender;
            //    }
            //    //查询该轮次的最大步骤
            //    int maxStep = 0;
            //    List<Tb_taskResult> result = TaskResultCache.getCache().Where(t => t.taskId == taskInfoId && t.taskRound  == i).ToList();
            //    try
            //    {
            //        maxStep = result.Max(x => x.taskStep);
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    xAxis.Add("最大步骤");
            //    yAxis.Add(maxStep);
            //    reportChart.Series[seriesName].Points.DataBindXY(xAxis, yAxis);
            //    //reportChart.Series[seriesName].Points[0].wi
            //}
            //string title = "轮次的最大步骤";
            //reportChart.Titles.Add(title);
            //reportChart.Titles[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;



            //reportChart.ChartAreas[0].AxisY.Maximum = 10;//设置Y轴最大值
            //reportChart.ChartAreas[0].AxisY.Minimum = 0; //设置Y轴最小值
            //reportChart.ChartAreas[0].Position.Width = 100;
        }

        private void btn_query_Click(object sender, EventArgs e)
         {
            DateTime time = new DateTime();
            if (startTime.Value == time)
            {
                MessageBoxEx.Show("请选择起始时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (endTime.Value == time)
            {
                MessageBoxEx.Show("请选择结束时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            if (chartTaskClassify.SelectedItem == null)
            {
                MessageBoxEx.Show("请选择要生成的测试任务", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            reportChart.Visible = true;
            string startTimeStr = startTime.Value.ToShortDateString();
            string endTimeStr = endTime.Value.ToShortDateString();
            List<queryEveryPersonTaskNum> queryList = CountChartAdapter.selectEveryPersonTaskNum(startTimeStr,endTimeStr);
            //queryEveryPersonTaskNum test = new queryEveryPersonTaskNum();
            //test.taskExecutor = "赵领飞";
            //test.dateNum = "2020.09";
            //test.number = 200;
            //queryList.Add(test);
            //test = new queryEveryPersonTaskNum();
            //test.taskExecutor = "赵领飞";
            //test.dateNum = "2020.08";
            //test.number = 100;
            //queryList.Add(test);
            //test = new queryEveryPersonTaskNum();
            //test.taskExecutor = "赵领飞";
            //test.dateNum = "2020.07";
            //test.number = 30;
            //queryList.Add(test);


            #region 第一步,先拿到所有的测试人员,作为系列名
            List<string> seriesName = new List<string>();
            xAxis.Clear();
            foreach (var item in queryList)
            {
                if (seriesName.Contains(item.taskExecutor) == false)
                {
                    seriesName.Add(item.taskExecutor);
                }
                if (xAxis.Contains(item.dateNum) == false)
                {
                    xAxis.Add(item.dateNum);
                }
            }
            #endregion
            #region 第二步,根据名称,查找数据,并进行绑定
            reportChart.Series.Clear();
            for (int i = 0; i < seriesName.Count; i++)
            {
                string name = seriesName[i];
                reportChart.Series.Add(name);
                reportChart.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                yAxis.Clear();
                for (int j = 0; j < xAxis.Count; j++)
                {
                    queryEveryPersonTaskNum taskNum = queryList.Find(x => x.taskExecutor == name && x.dateNum == xAxis[j]);
                    if (taskNum == null)
                    {
                        yAxis.Add(0);
                    }
                    else
                    {
                        yAxis.Add(taskNum.number);
                    }
                }

                reportChart.Series[name].Points.DataBindXY(xAxis, yAxis);
                reportChart.Series[name].IsValueShownAsLabel = true;
            }
            #endregion
            string title = "不同测试员的测试项数量";
            reportChart.Titles.Clear();
            if (reportChart.Titles.Count == 0 && seriesName.Count !=0)
            {
                reportChart.Titles.Add(title);
                reportChart.Titles[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            }
        }
    }
}
