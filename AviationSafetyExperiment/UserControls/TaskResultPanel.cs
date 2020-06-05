using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationSafetyExperiment.DbLocalCache;
using AviationSafetyExperiment.Model;
using DevComponents.DotNetBar.Controls;
using AviationSafetyExperiment.Db.Entity;

namespace AviationSafetyExperiment.UserControls
{
    /// <summary>
    /// 任务指标及测试结果列表
    /// </summary>
    public partial class TaskResultPanel : UserControl
    {
        List<Tb_taskResult> taskResultMapList;
        List<ListItem> items = new List<ListItem>();
        private int taskId;
        private int maxResultRound,currentResultRound;

        public TaskResultPanel()
        {
            InitializeComponent();
            items.Add(new ListItem("0", "未测试"));
            items.Add(new ListItem("1", "未通过"));
            items.Add(new ListItem("2", "已通过"));
            this.taskResult.DataSource = items;
            this.taskResult.DisplayMember = "Text";
            this.taskResult.ValueMember = "Value";
        }

        /// <summary>
        /// 加载任务指标及测试结果
        /// </summary>
        /// <param name="taskInfoId"></param>
        public void init(int taskInfoId,bool readOnly=false)
        {
            taskId = taskInfoId;
            taskResultMapList = TaskResultCache.getCache().Where(t => t.taskId == taskId).ToList();
            maxResultRound = 0;
            try
            {
                maxResultRound = taskResultMapList.Max(x => x.taskRound);
            }
            catch (Exception)
            {
            }
            
            dgv.DataSource = null;
            dgv.DataSource = getData(maxResultRound);
            dgv.AutoGenerateColumns = false;
            setReadOnly(readOnly);
        }

        private List<TaskResultModel> getData(int round)
        {
            var taskIndicatorMapList = TaskIndicatorMapCache.getCache().Where(i => i.taskId == taskId).ToList();
            var indicatorList = IndicatorCache.getCache();
            var brandList = CodeCache.getBrand();
            var modelList = CodeCache.getModel();
            var taskModelList = TaskModelMapCache.getCache();
            //todo ***************确定后将下列ToList都去掉******************
            var brand_model_list = (from brand in brandList
                                    from model in modelList
                                    where brand.id == model.parentId
                                    select new
                                    {
                                        modelId = model.id,
                                        modelName = model.codeName,
                                        brandId = brand.id,
                                        brandName = brand.codeName
                                    }).ToList();

            var task_model_indicator_list = (from taskIndicator in taskIndicatorMapList
                                             from taskModel in taskModelList
                                             from bm in brand_model_list
                                             where taskIndicator.taskId == taskId && taskModel.taskId == taskId && taskModel.ModelId == bm.modelId
                                             select new
                                             {
                                                 taskIndicator,
                                                 bm.brandId,
                                                 bm.brandName,
                                                 bm.modelId,
                                                 bm.modelName
                                             }).ToList();

            var list_indicator = (from indicator in task_model_indicator_list
                                  join result in taskResultMapList.Where(r => r.taskRound == round) on new { indicator.taskIndicator.indicatorId, indicator.modelId } equals new { result.indicatorId, result.modelId } into temp
                                  from tt in temp.DefaultIfEmpty()
                                  select new
                                  {
                                      indicator,
                                      taskRecord = tt == null ? "" : tt.taskRecord,
                                      taskResult = tt == null ? 0 : tt.taskResult,
                                      taskRemark = tt == null ? "" : tt.taskRemark,
                                      taskExecutor = tt == null ? "" : tt.taskExecutor,
                                      taskDateTime = tt == null ? "" : tt.taskDateTime.ToString(),
                                      taskRound = tt == null ? 0 : tt.taskRound,
                                      modelId = tt == null ? 0 : tt.modelId,
                                      taskResultId = tt == null ? 0 : tt.id
                                  }).ToList();

            var list = (from temp in list_indicator
                        from indicator in indicatorList
                        where temp.indicator.taskIndicator.indicatorId == indicator.id
                        select new TaskResultModel
                        {
                            indicatorId = indicator.id,
                            indicatorName = indicator.indicatorName,
                            indicatorDesc = indicator.indicatorDesc,
                            taskDateTime = temp.taskDateTime,
                            taskRound = temp.taskRound,
                            taskExecutor = temp.taskExecutor,
                            taskRecord = temp.taskRecord,
                            taskRemark = temp.taskRemark,
                            taskResult = temp.taskResult,
                            modelId = temp.indicator.modelId,
                            modelName = temp.indicator.modelName,
                            brandId = temp.indicator.brandId,
                            brandName = temp.indicator.brandName,
                            taskResultId = temp.taskResultId
                        }).ToList();

            return list;
        }

        private void setReadOnly(bool readOnly)
        {
            dgv.Columns["taskResult"].ReadOnly = readOnly;
            dgv.Columns["taskRecord"].ReadOnly = readOnly;
            dgv.Columns["taskRemark"].ReadOnly = readOnly;
        }

        List<string> colsHeaderText_H = new List<string>() { "指标名称","指标描述"};
        /// <summary>
        /// 合并单元格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (string fieldHeaderText in colsHeaderText_H)
            {
                //纵向合并
                if (e.ColumnIndex >= 0 && this.dgv.Columns[e.ColumnIndex].HeaderText == fieldHeaderText && e.RowIndex >= 0)
                {
                    using (
                        Brush gridBrush = new SolidBrush(Color.Black),
                        backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            // 擦除原单元格背景
                            e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                            /****** 绘制单元格相互间隔的区分线条，datagridview自己会处理左侧和上边缘的线条，因此只需绘制下边框和和右边框
                             DataGridView控件绘制单元格时，不绘制左边框和上边框，共用左单元格的右边框，上一单元格的下边框*****/
                            //不是最后一行且单元格的值不为null
                            if (e.RowIndex < this.dgv.RowCount - 1 && this.dgv.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value != null)
                            {
                                //若与下一单元格值不同
                                if (e.Value.ToString() != this.dgv.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value.ToString())
                                {
                                    //下边缘的线
                                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1,
                                    e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                                    //绘制值
                                    if (e.Value != null)
                                    {
                                        e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font,
                                            Brushes.Crimson, e.CellBounds.X + 2,
                                            e.CellBounds.Y - 0, StringFormat.GenericDefault);//
                                    }
                                }
                                //若与下一单元格值相同 
                                else
                                {
                                    //背景颜色
                                    //e.CellStyle.BackColor = Color.LightPink;   //仅在CellFormatting方法中可用
                                    this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
                                    this.dgv.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
                                    //只读（以免双击单元格时显示值）
                                    this.dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                                    this.dgv.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].ReadOnly = true;
                                }
                            }
                            //最后一行或单元格的值为null
                            else
                            {
                                //下边缘的线
                                e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1,
                                    e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);

                                //绘制值
                                if (e.Value != null)
                                {
                                    e.Graphics.DrawString(e.Value.ToString(), e.CellStyle.Font,
                                        Brushes.Crimson, e.CellBounds.X + 2,
                                        e.CellBounds.Y + 2, StringFormat.GenericDefault);
                                }
                            }

                            ////左侧的线（）
                            //e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                            //    e.CellBounds.Top, e.CellBounds.Left,
                            //    e.CellBounds.Bottom - 1);

                            //右侧的线
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                                e.CellBounds.Top, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);

                            //设置处理事件完成（关键点），只有设置为ture,才能显示出想要的结果。
                            e.Handled = true;
                        }
                    }
                    //e.CellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
        }

        string oldValue;
        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (oldValue != dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
            {
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightSeaGreen;
            }
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        #region 用于显示测试历程，供外部调用
        /// <summary>
        /// 获取测试结果全部历史记录
        /// </summary>
        /// <returns>总轮次</returns>
        public int getHistory()
        {
            if (maxResultRound > 0)
            {
                currentResultRound = 1;//如果有轮次，则将currentResultRound设为1，以显示第1轮
                dgv.DataSource = null;
                dgv.DataSource = getData(currentResultRound);
            }
            return maxResultRound;
        }
        /// <summary>
        /// 显示下一轮测试结果
        /// </summary>
        /// <returns>下一轮轮次</returns>
        public int showNext()
        {
            currentResultRound += 1;
            if (currentResultRound <= maxResultRound)
            {
                dgv.DataSource = null;
                dgv.DataSource = getData(currentResultRound);
            }
            return currentResultRound;
        }
        /// <summary>
        /// 显示上一轮测试结果
        /// </summary>
        /// <returns>上一轮轮次</returns>
        public int showPrevious()
        {
            currentResultRound -= 1;
            if (currentResultRound > 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = getData(currentResultRound);
            }
            return currentResultRound;
        }
        #endregion
    }

    /// <summary>
    /// 用于绑定dgv中的下拉列表
    /// </summary>
    public class ListItem
    {
        private string _Value = string.Empty;
        private string _Text = string.Empty;

        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return this._Value; }

            set { this._Value = value; }
        }
        /// <summary>
        /// 显示的文本
        /// </summary>
        public string Text
        {
            get { return this._Text; }

            set { this._Text = value; }
        }

        public ListItem(string value, string text)
        {
            this._Value = value;
            this._Text = text;
        }
        public override string ToString()
        {
            return this._Text;
        }
    }
}
