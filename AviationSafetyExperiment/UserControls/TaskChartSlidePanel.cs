using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.DbLocalCache;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskChartSlidePanel : UserControl
    {
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskChartSlidePanel()
        {
            InitializeComponent();
            InitChartDataSource();
        }

        private void InitChartDataSource()
        {
            List<string> xAxis = new List<string>();
            List<int> yAxis = new List<int>();
            #region 上面图表的绑定数据源代码
            List<queryDateResult> queryList = CountChartAdapter.selectEveryMonthTaskNum();
            chartMonthCountTask.Series.Clear();
            chartMonthCountTask.Series.Add("月");
            chartMonthCountTask.Series["月"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in queryList)
            {
                xAxis.Add(item.dateNum);
                yAxis.Add(item.number);
            }
            chartMonthCountTask.Series["月"].Points.DataBindXY(xAxis, yAxis);
            chartMonthCountTask.Series["月"].IsValueShownAsLabel = true;
            string title = "近6个月的任务数量情况";
            chartMonthCountTask.Titles.Add(title);
            chartMonthCountTask.Titles[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            #endregion
            #region 下面图表的绑定数据源代码
            xAxis.Clear();
            yAxis.Clear();
            List<queryClassifyResult> clsssifyList = CountChartAdapter.selectClassifyNum();
            chartClassify.Series.Clear();
            chartClassify.Series.Add("测试分类");
            chartClassify.Series["测试分类"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in clsssifyList)
            {
                List<Db.Entity.Tb_code> codeList = CodeCache.getCache().Where(x => x.id == int.Parse(item.taskClass)).ToList();
                if (codeList != null)
                {
                    xAxis.Add(codeList[0].codeName);
                }
                yAxis.Add(item.number);
                //xAxis.Add()
                //xAxis.Add(item.dateNum);
                //yAxis.Add(item.number);
            }
            chartClassify.Series["测试分类"].Points.DataBindXY(xAxis, yAxis);
            chartClassify.Series["测试分类"].IsValueShownAsLabel = true;
            string classTitle = "测试分类的任务数量情况";
            chartClassify.Titles.Add(classTitle);
            chartClassify.Titles[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            #endregion
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            DialogResult result = chartForm.ShowDialog(this);
        }
    }
}
