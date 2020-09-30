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
using System.IO;
using AviationSafetyExperiment.Utils;
using DevComponents.DotNetBar;

namespace AviationSafetyExperiment.UserControls
{
    /// <summary>
    /// 任务指标及测试结果列表
    /// </summary>
    public partial class TaskResultPanel : UserControl, IPagging
    {
        List<Tb_taskResult> taskResultMapList;
        List<TaskResultModel> allResultModelList = new List<TaskResultModel>();
        List<ListItem> items = new List<ListItem>();
        private int taskId;
        public int taskRound;
        public int maxResultStep, currentResultStep;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskResultPanel()
        {
            InitializeComponent();
            items.Add(new ListItem("0", "未测试"));
            items.Add(new ListItem("1", "未通过"));
            items.Add(new ListItem("2", "已通过"));
            this.taskResult.DataSource = items;
            this.taskResult.DisplayMember = "Text";
            this.taskResult.ValueMember = "Value";
            this.dgv.AutoGenerateColumns = false;
            pagingPanel.pagging = this;

            attachmentCount.ButtonCustomClick += Attachment_ButtonCustomClick;
            attachmentCount.ButtonCustom2Click += AttachmentCount_ButtonCustom2Click;
            //attachmentCount.ButtonCustom2Click += Attachment_ButtonCustom2Click;
            //attachmentCount.ButtonClearClick += Attachment_ButtonClearClick;
        }

        /// <summary>
        /// 加载任务指标及测试结果
        /// </summary>
        /// <param name="taskInfoId"></param>
        public void init(int taskInfoId, bool readOnly = false, int taskRound = 1)
        {
            taskId = taskInfoId;
            this.taskRound = taskRound;
            taskResultMapList = TaskResultCache.getCache().Where(t => t.taskId == taskId && t.taskRound == taskRound).ToList();
            maxResultStep = 0;
            try
            {
                maxResultStep = taskResultMapList.Max(x => x.taskStep);
                currentResultStep = maxResultStep;
            }
            catch (Exception ex)
            {
            }

            dgv.DataSource = null;
            dgv.DataSource = getData(maxResultStep, this.taskRound);
            dgv.AutoGenerateColumns = false;
            setReadOnly(readOnly);
        }

        public List<TaskResultModel> getData(int step,int round)
        {
            var taskIndicatorMapList = TaskIndicatorMapCache.getCache().Where(i => i.taskId == taskId).ToList();
            var indicatorList = IndicatorCache.getCache();
            var brandList = CodeCache.getBrand();
            var modelList = CodeCache.getModel();
            var taskModelList = TaskModelMapCache.getCache();
            if (round == 1)
            {
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
                                      join result in taskResultMapList.Where(r => r.taskStep == step && r.taskRound == round) 
                                      on new { indicator.taskIndicator.indicatorId, indicator.modelId } 
                                      equals new { result.indicatorId, result.modelId } into temp
                                      from tt in temp.DefaultIfEmpty()
                                      select new
                                      {
                                          indicator,
                                          taskRecord = tt == null ? "" : tt.taskRecord,
                                          taskResult = tt == null ? 0 : tt.taskResult,
                                          taskRemark = tt == null ? "" : tt.taskRemark,
                                          attachment = tt == null ? "" : tt.attachment,
                                          taskExecutor = tt == null ? "" : tt.taskExecutor,
                                          taskDateTime = tt == null ? "" : tt.taskDateTime.ToString(),
                                          taskStep = tt == null ? 0 : tt.taskStep,
                                          modelId = tt == null ? 0 : tt.modelId,
                                          taskResultId = tt == null ? 0 : tt.id,
                                          supplement = tt == null ? "" : tt.supplement
                                      }).ToList();

                allResultModelList = (from temp in list_indicator
                                      from indicator in indicatorList
                                      where temp.indicator.taskIndicator.indicatorId == indicator.id
                                      select new TaskResultModel
                                      {
                                          indicatorId = indicator.id,
                                          indicatorName = indicator.indicatorName,
                                          indicatorDesc = indicator.indicatorDesc,
                                          indicatorInstr = indicator.indicatorInstr,
                                          taskDateTime = temp.taskDateTime,
                                          taskStep = temp.taskStep,
                                          taskExecutor = temp.taskExecutor,
                                          taskRecord = temp.taskRecord,
                                          taskRemark = temp.taskRemark,
                                          attachment = temp.attachment,
                                          attachmentCount = (temp.attachment == string.Empty ? "" : temp.attachment.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Count() + "个")
                                          + (temp.supplement == "" ? "" : "(补)"),
                                          taskResult = temp.taskResult,
                                          modelId = temp.indicator.modelId,
                                          modelName = temp.indicator.modelName,
                                          brandId = temp.indicator.brandId,
                                          brandName = temp.indicator.brandName,
                                          taskResultId = temp.taskResultId,
                                          supplement = temp.supplement
                                      }).ToList();
            }
            else
            {
                allResultModelList = (from resultList in TaskResultCache.getCache()
                                      from indicator in indicatorList
                                      from brand in brandList
                                      from model in modelList
                                      where resultList.modelId == model.id
                                      && model.parentId == brand.id
                                      && resultList.indicatorId == indicator.id
                                      && resultList.taskId == taskId
                                      && resultList.taskRound == round
                                      && resultList.taskStep == step
                                      select new TaskResultModel
                                      {
                                          indicatorId = resultList.indicatorId,
                                          indicatorName = indicator.indicatorName,
                                          indicatorDesc = indicator.indicatorDesc,
                                          indicatorInstr = indicator.indicatorInstr,
                                          brandId = brand.id,
                                          brandName = brand.codeName,
                                          modelId = model.id,
                                          modelName = model.codeName,
                                          taskStep = resultList.taskStep,
                                          taskExecutor = resultList.taskExecutor,
                                          taskDateTime = resultList.taskDateTime.ToString(),
                                          taskRecord = resultList.taskRecord,
                                          taskResult = resultList.taskResult,
                                          taskResultId = resultList.id,
                                          taskRemark = resultList.taskRemark,
                                          attachment = resultList.attachment,
                                          attachmentCount = "",
                                          supplement = resultList.supplement
                                      }).ToList();
            }
            
            pagingPanel.setDetail(allResultModelList.Count);
            return allResultModelList.Skip(pageSize * (pageNum - 1)).Take(pageSize).ToList();
        }
        public void setReadOnly(bool readOnly)
        {
            dgv.Columns["taskResult"].ReadOnly = readOnly;
            dgv.Columns["taskRecord"].ReadOnly = readOnly;
            dgv.Columns["taskRemark"].ReadOnly = readOnly;
            dgv.Columns["attachmentCount"].ReadOnly = readOnly;
        }
        public void maxRoundInit(int taskInfoId,bool readOnly = false,int taskRound = 1)
        {
            taskId = taskInfoId;
            this.taskRound = taskRound;
            taskResultMapList = TaskResultCache.getCache().Where(t => t.taskId == taskId && t.taskRound == taskRound && t.taskStep == 1).ToList();
            List<Tb_taskResult> allResult =TaskResultCache.getCache().Where(t => t.taskId == taskId && t.taskRound == taskRound).ToList();
            maxResultStep = 0;
            try
            {
                maxResultStep = allResult.Max(x => x.taskStep);
                currentResultStep = maxResultStep;
            }
            catch (Exception ex)
            {
            }
            var result = (from resultList in taskResultMapList
                          join resultAll in TaskResultCache.getCache().Where(r => r.taskId == taskInfoId && r.taskStep == maxResultStep &&  r.taskRound == taskRound)
                          on new { resultList.indicatorId, resultList.modelId }
                          equals new { resultAll.indicatorId, resultAll.modelId } into temp
                          from tt in temp.DefaultIfEmpty()
                          select new
                          {
                              attachment = tt == null? resultList.attachment: tt.attachment,
                              resultList.id,
                              resultList.indicatorId,
                              resultList.modelId,
                              supplement=tt==null? resultList.supplement: tt.supplement,
                              taskDateTime=tt==null? resultList.taskDateTime: tt.taskDateTime,
                              resultList.taskExecutor,
                              resultList.taskId,
                              taskRecord=tt==null? resultList.taskRecord: tt.taskRecord,
                              taskRemark=tt==null? resultList.taskRemark: tt.taskRemark,
                              taskResult=tt==null? resultList.taskResult: tt.taskResult,
                              taskRound = taskRound,
                              taskStep =maxResultStep
                              //resultList.taskRecord = tt.taskRecord
                          }).ToList();
            var indicatorList = IndicatorCache.getCache();
            var brandList = CodeCache.getBrand();
            var modelList = CodeCache.getModel();
            List<TaskResultModel> resultModel = (from resultList in result
                                                 from indicator in indicatorList
                                                 from brand in brandList
                                                 from model in modelList
                                                 where resultList.modelId == model.id
                                                 && model.parentId == brand.id
                                                 && resultList.indicatorId == indicator.id
                                                 select new TaskResultModel
                                                 {
                                                     indicatorId = resultList.indicatorId,
                                                     indicatorName = indicator.indicatorName,
                                                     indicatorDesc = indicator.indicatorDesc,
                                                     indicatorInstr = indicator.indicatorInstr,
                                                     brandId = brand.id,
                                                     brandName = brand.codeName,
                                                     modelId = model.id,
                                                     modelName = model.codeName,
                                                     taskStep = resultList.taskStep,
                                                     taskExecutor = resultList.taskExecutor,
                                                     taskDateTime = resultList.taskDateTime.ToString(),
                                                     taskRecord = resultList.taskRecord,
                                                     taskResult = resultList.taskResult,
                                                     taskResultId = resultList.id,
                                                     taskRemark = resultList.taskRemark,
                                                     attachment = resultList.attachment,
                                                     attachmentCount = "",
                                                     supplement = resultList.supplement
                                                 }).ToList();
            dgv.DataSource = null;
            dgv.DataSource = resultModel;
            setReadOnly(readOnly);
        }
        List<string> colsHeaderText_H = new List<string>() { "指标名称", "指标描述", "操作说明" };
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
                    using (Brush gridBrush = new SolidBrush(Color.Black), backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            // 擦除原单元格背景
                            e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                            /****** 绘制单元格相互间隔的区分线条，datagridview自己会处理左侧和上边缘的线条，因此只需绘制下边框和和右边框
                             DataGridView控件绘制单元格时，不绘制左边框和上边框，共用左单元格的右边框，上一单元格的下边框*****/
                            //不是最后一行且单元格的值不为null
                            if (e.Value != null && e.RowIndex < this.dgv.RowCount - 1 && this.dgv.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value != null)
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
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (oldValue != dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightSeaGreen;
                }
            }
        }

        private void dgv_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                oldValue = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //绘制行序号
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font,
                   rectangle, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        /// <summary>
        /// 上传附件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attachment_ButtonCustomClick(object sender, EventArgs e)
        {
            DataGridViewMaskedTextBoxAdvCell cell = dgv.CurrentCell as DataGridViewMaskedTextBoxAdvCell;
            if (cell != null)
            {
                var indicatorId = (int)dgv.Rows[cell.RowIndex].Cells["indicatorId"].Value;
                var brandId = (int)dgv.Rows[cell.RowIndex].Cells["brandId"].Value;
                var modelId = (int)dgv.Rows[cell.RowIndex].Cells["modelId"].Value;
                var attachment = dgv.Rows[cell.RowIndex].Cells["attachment"].Value.ToString();
                FtpListForm flf = new AviationSafetyExperiment.FtpListForm(taskId, indicatorId, brandId, modelId, attachment);
                var flfState = flf.ShowDialog(this);
                if (flfState == DialogResult.OK)
                {
                    string remoteFiles = flf.remoteFiles;
                    DataGridViewMaskedTextBoxAdvEditingControl ec = cell.DataGridView.EditingControl as DataGridViewMaskedTextBoxAdvEditingControl;
                    if (ec != null)
                    {
                        dgv.Rows[cell.RowIndex].Cells["attachment"].Value = remoteFiles;
                        if (ec.Text.Contains("补"))
                        {
                            ec.Text = (remoteFiles == string.Empty ? "" : remoteFiles.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Count() + "个") + "(补)";
                        }
                        else
                        {
                            ec.Text = remoteFiles == string.Empty ? "" : remoteFiles.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).Count() + "个";
                        }
                    }
                }
                ////原逻辑，单文件上传
                //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    string localFilePath = ofd.FileName;
                //    string extension = Path.GetExtension(localFilePath);
                //    string remoteFilePath = RemoteFileNameMaker.makeName(taskId, indicatorId, brandId, modelId, extension);
                //    DataGridViewMaskedTextBoxAdvEditingControl ec = cell.DataGridView.EditingControl as DataGridViewMaskedTextBoxAdvEditingControl;
                //    FtpProcessForm fpf = new FtpProcessForm(localFilePath, remoteFilePath, true);
                //    var uploadState = fpf.ShowDialog();
                //    if (uploadState == DialogResult.OK)
                //    {
                //        MessageBoxEx.Show("上传完成");
                //        if (ec != null)
                //        {
                //            dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = remoteFilePath;
                //            ec.Text = remoteFilePath;
                //        }
                //    }
                //    if (uploadState == DialogResult.No)
                //    {
                //        MessageBoxEx.Show("上传失败");
                //    }
                //}
            }
        }
        /// <summary>
        /// 点击查看附件事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attachment_ButtonCustom2Click(object sender, EventArgs e)
        {
            DataGridViewMaskedTextBoxAdvCell cell = dgv.CurrentCell as DataGridViewMaskedTextBoxAdvCell;
            if (cell != null)
            {
                if (dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value != null)
                {
                    if (dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString() != string.Empty)
                    {
                        string remoteFilePath = dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString();
                        string localFilePath = Application.StartupPath + @"\temp" + remoteFilePath.Replace("/", @"\");
                        string localFileFolder = Path.GetDirectoryName(localFilePath);//获取待下载文件的下载后目录，如不存在目录则先创建
                        if (!Directory.Exists(localFileFolder))
                        {
                            Directory.CreateDirectory(localFileFolder);
                        }
                        FtpProcessForm fpf = new FtpProcessForm(localFilePath, remoteFilePath, false);
                        var downloadState = fpf.ShowDialog();
                        if (downloadState == DialogResult.OK)
                        {
                            System.Diagnostics.Process.Start("explorer.exe", localFilePath);//打开下载的文件
                        }
                        else
                        {
                            MessageBoxEx.Show("下载附件失败");
                        }
                    }
                }
            }
        }
        //清除附件按钮
        private void Attachment_ButtonClearClick(object sender, CancelEventArgs e)
        {
            DataGridViewMaskedTextBoxAdvCell cell = dgv.CurrentCell as DataGridViewMaskedTextBoxAdvCell;
            if (cell != null)
            {
                dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = string.Empty;
            }
        }
        /// <summary>
        /// 点击打开补录窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttachmentCount_ButtonCustom2Click(object sender, EventArgs e)
        {
            DataGridViewMaskedTextBoxAdvCell cell = dgv.CurrentCell as DataGridViewMaskedTextBoxAdvCell;
            if (cell != null)
            {
                if (dgv.Rows[cell.RowIndex].Cells["supplement"].Value != null)
                {
                    string supplementJsonString = dgv.Rows[cell.RowIndex].Cells["supplement"].Value.ToString();
                    SupplementForm sf = new SupplementForm(supplementJsonString);
                    if (sf.ShowDialog(this) == DialogResult.OK)
                    {
                        dgv.Rows[cell.RowIndex].Cells["supplement"].Value = sf.getSupplimentJsonString();
                        if (dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString().Contains("补") == false)
                        {
                            dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString() + "(补)";
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 双击事件：双击附件时打开附件内容；双击指标项时显示指标细节
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (dgv.Columns[e.ColumnIndex].Name == "attachmentCount")
                {
                    if (dgv.Rows[e.RowIndex].Cells["attachment"].Value != null)
                    {
                        if (dgv.Rows[e.RowIndex].Cells["attachment"].Value.ToString() != string.Empty|| dgv.Rows[e.RowIndex].Cells["supplement"].Value.ToString() != string.Empty)
                        {
                            #region 过时代码
                            ////只有单个附件，直接打开
                            //if (dgv.Rows[e.RowIndex].Cells["attachmentCount"].Value.ToString().Replace("(补)", "") == "1个")
                            //{
                            //    string remoteFilePath = dgv.Rows[e.RowIndex].Cells["attachment"].Value.ToString();
                            //    string localFilePath = Application.StartupPath + @"\temp" + remoteFilePath.Replace("/", @"\");
                            //    string localFileFolder = Path.GetDirectoryName(localFilePath);//获取待下载文件的下载后目录，如不存在目录则先创建
                            //    if (!Directory.Exists(localFileFolder))
                            //    {
                            //        Directory.CreateDirectory(localFileFolder);
                            //    }
                            //    FtpProcessForm fpf = new FtpProcessForm(localFilePath, remoteFilePath, false);
                            //    var downloadState = fpf.ShowDialog();
                            //    if (downloadState == DialogResult.OK)
                            //    {
                            //        System.Diagnostics.Process.Start("explorer.exe", localFilePath);//打开下载的文件
                            //    }
                            //    else
                            //    {
                            //        MessageBoxEx.Show("下载附件失败");
                            //    }
                            //}
                            //else//多个附件，打开附件列表窗体
                            //{
                            //    string remoteFilePath = dgv.Rows[e.RowIndex].Cells["attachment"].Value.ToString();
                            //    FtpListForm flf = new FtpListForm(remoteFilePath);
                            //    flf.ShowDialog();
                            //}
                            #endregion
                            //附件和补漏报合并显示，所以附件无论单个还是多个，都要打开附件列表
                            string remoteFilePath = dgv.Rows[e.RowIndex].Cells["attachment"].Value.ToString();
                            string supplementJsonString = dgv.Rows[e.RowIndex].Cells["supplement"].Value.ToString();
                            FtpListForm flf = new FtpListForm(remoteFilePath, supplementJsonString);
                            flf.ShowDialog();
                        }
                    }
                }
                if (dgv.Columns[e.ColumnIndex].Name == "indicatorInstr"|| dgv.Columns[e.ColumnIndex].Name == "indicatorDesc"|| dgv.Columns[e.ColumnIndex].Name == "indicatorName")
                {
                    IndicatorEdit ie = new AviationSafetyExperiment.IndicatorEdit(_readOnly: true);
                    var indicatorIdValue = dgv.Rows[e.RowIndex].Cells["indicatorId"].Value.ToString();
                    int indicatorId;
                    if (int.TryParse(indicatorIdValue, out indicatorId))
                    {
                        ie.indicator = IndicatorCache.getCache().FirstOrDefault(i => i.id == indicatorId);
                        ie.Show(this);
                    }
                }
            }
        }

        #region 分页
        int pageSize = 10;//默认每页10条
        int pageNum = 1;//默认首页
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        public void doPagging(int pageNum, int pageSize)
        {
            this.pageNum = pageNum;
            this.pageSize = pageSize;
            dgv.DataSource = null;
            dgv.DataSource = getData(currentResultStep, this.taskRound);
        }
        #endregion

        #region 用于显示测试历程，供外部调用
        /// <summary>
        /// 获取测试结果全部历史记录
        /// </summary>
        /// <returns>总轮次</returns>
        public int getHistory()
        {
            if (maxResultStep > 0)
            {
                currentResultStep = 1;//如果有轮次，则将currentResultRound设为1，以显示第1轮
                dgv.DataSource = null;
                dgv.DataSource = getData(currentResultStep, this.taskRound);
            }
            return maxResultStep;
        }
        /// <summary>
        /// 显示下一步测试结果
        /// </summary>
        /// <returns>下一步步次</returns>
        public int showNext()
        {
            currentResultStep += 1;
            if (currentResultStep <= maxResultStep)
            {
                dgv.DataSource = null;
                dgv.DataSource = getData(currentResultStep, this.taskRound);
            }
            return currentResultStep;
        }

        /// <summary>
        /// 显示上一步测试结果
        /// </summary>
        /// <returns>上一步步次</returns>
        public int showPrevious()
        {
            currentResultStep -= 1;
            if (currentResultStep > 0)
            {
                dgv.DataSource = null;
                dgv.DataSource = getData(currentResultStep, this.taskRound);
            }
            return currentResultStep;
        }
        #endregion
        #region 返回测试项总数，供外部调用，用于计算完成进度百分比
        /// <summary>
        /// 返回测试项总数
        /// </summary>
        /// <returns></returns>
        public int getAllResultModelCount()
        {
            return allResultModelList.Count;
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
