using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using AviationSafetyExperiment.Model;
using AviationSafetyExperiment.UserControls;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    public partial class TaskNewRoundDefine : DevComponents.DotNetBar.Office2007Form, IPagging
    {
        private int taskInfoId, currentRound;
        private List<Tb_indicator> indicatorList;
        //private List<Tb_code> classList;
        private List<Tb_code> detectionList;
        private List<Tb_code> subDetectionList;
        #region 分页
        int pageSize_selected = 10;//默认每页10条
        int pageNum_selected = 1;//默认首页
        int pageSize_unselect = 10;//默认每页10条
        int pageNum_unselect = 1;//默认首页
        #endregion

        //IEnumerable<Tb_indicatorTemplate> templateList = new List<Tb_indicatorTemplate>();
        /// <summary>
        /// 模板中的已选指标
        /// </summary>
        List<IndicatorForTemplateModel> selectedIndicatorModelList = new List<IndicatorForTemplateModel>();
        /// <summary>
        /// 模板中的待选指标
        /// </summary>
        List<IndicatorForTemplateModel> unselectedIndicatorModelList = new List<IndicatorForTemplateModel>();

        [Browsable(true)]
        public bool isManage { get; set; } = true;//是否处于指标模板管理界面中，用于控制控件状态和行为
        public TaskNewRoundDefine(int taskInfoId,int round)
        {
            InitializeComponent();
            this.taskInfoId = taskInfoId;
            this.currentRound = round;
            dgv_selected.AutoGenerateColumns = false;
            dgv_unselected.AutoGenerateColumns = false;
            pagingPanel_selected.pagging = this;
            pagingPanel_unselected.pagging = this;
            initPaggingParams();
        }
        /// <summary>
        /// 初始化分页参数。当控件初始化、或已有模板下拉列表变化时调用本方法.
        /// </summary>
        private void initPaggingParams()
        {
            pageSize_selected = 10;//默认每页10条
            pageNum_selected = 1;//默认首页
            pageSize_unselect = 10;//默认每页10条
            pageNum_unselect = 1;//默认首页
        }

        public void init()
        {
            getAllList();
            stc.SelectedTab = sti_selected;
        }
        private void getAllList()
        {
            indicatorList = IndicatorCache.getCache();
            detectionList = CodeCache.getDetection();
            subDetectionList = CodeCache.getSubDetection();
        }

        public void getTemplateIndicators()
        {
            progressBar.Visible = true;
            initPaggingParams();
            IProgress<string> progress = new Progress<string>(value => {
                progressBar.Text = value;
            });
            var data = getData(progress);
            if (data.IsCompleted)
            {
                data.Wait();
            }
        }

        private async Task getData(IProgress<string> progress)
        {
            var taskInfo = TaskCache.getCacheById(taskInfoId);
            var classInfo = CodeCache.getClass().FirstOrDefault(c => c.id == taskInfo.taskClass);
            //获取某任务下某轮次的所有指标测试结果
            var currentRoundIndicatorList = TaskResultCache.getCache().Where(r => r.taskId == taskInfoId && r.taskRound == currentRound).ToList();
            
            progress.Report("获取前序轮次全部指标");
            await Task.Factory.StartNew(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var childOne = Task.Factory.StartNew(() =>
                {
                    //获取所有未通过指标作为已选指标
                    var currentRoundRejectedIndicatorIdList = currentRoundIndicatorList.Where(r => r.taskResult == 1).Select(r => r.id).ToList();
                    var currentRoundRejectedIndicatorList = from indicator in IndicatorCache.getCache()
                                                            where currentRoundRejectedIndicatorIdList.Contains(indicator.id)
                                                            select indicator;
                    //结果2为已通过，1为未通过
                    //生成已选指标model对象列表
                    selectedIndicatorModelList = (from indicator in currentRoundRejectedIndicatorList
                                                      //from classType in classList
                                                  from detection in detectionList
                                                  from subDetection in subDetectionList
                                                  where indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                                                  select new IndicatorForTemplateModel()
                                                  {
                                                      classId = indicator.classId,
                                                      className = (classInfo==null?"": classInfo.codeName),//classType.codeName,
                                                      detectionId = detection.id,
                                                      detectionName = detection.codeName,
                                                      indicatorDesc = indicator.indicatorDesc,
                                                      indicatorInstr = indicator.indicatorInstr,
                                                      indicatorId = indicator.id,
                                                      indicatorName = indicator.indicatorName,
                                                      isObsolete = indicator.isObsolete == 1 ? "已废弃" : "生效中",
                                                      isSelected = false,
                                                      subDetectionId = subDetection.id,
                                                      subDetectionName = subDetection.codeName,
                                                  }).ToList();
                    progress.Report("指标计算中……");
                    Debug.WriteLine("one");
                }, TaskCreationOptions.AttachedToParent);
                var childTwo = Task.Factory.StartNew(() =>
                {
                    //获取所有已通过指标作为待选指标
                    var currentRoundPassedIndicatorIdList = currentRoundIndicatorList.Where(r => r.taskResult == 2).Select(r => r.id).ToList();
                    var currentRoundPassedIndicatorList = from indicator in IndicatorCache.getCache()
                                                            where currentRoundPassedIndicatorIdList.Contains(indicator.id)
                                                            select indicator;
                    //结果2为已通过，1为未通过
                    unselectedIndicatorModelList = (from indicator in currentRoundPassedIndicatorList
                                                        //from classType in classList
                                                    from detection in detectionList
                                                    from subDetection in subDetectionList
                                                    where indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                                                    select new IndicatorForTemplateModel()
                                                    {
                                                        classId = indicator.classId,
                                                        className = (classInfo == null ? "" : classInfo.codeName),// classType.codeName,
                                                        detectionId = detection.id,
                                                        detectionName = detection.codeName,
                                                        indicatorDesc = indicator.indicatorDesc,
                                                        indicatorInstr = indicator.indicatorInstr,
                                                        indicatorId = indicator.id,
                                                        indicatorName = indicator.indicatorName,
                                                        isObsolete = indicator.isObsolete == 1 ? "已废弃" : "生效中",
                                                        isSelected = false,
                                                        subDetectionId = subDetection.id,
                                                        subDetectionName = subDetection.codeName,
                                                    }).ToList();
                    progress.Report("指标计算中……");
                    Debug.WriteLine("two");
                }, TaskCreationOptions.AttachedToParent);
                sw.Stop();
                Debug.WriteLine(sw.ElapsedMilliseconds);
                progress.Report("指标获取中……");
            });
            bindDgv();
            progressBar.Visible = false;
        }

        private void bindDgv()
        {
            bindDgvSelected();
            bindDgvUnselected();
        }
        private void bindDgvSelected()
        {
            dgv_selected.DataSource = new List<IndicatorForTemplateModel>();
            pagingPanel_selected.setDetail(selectedIndicatorModelList.Count());
            dgv_selected.DataSource = selectedIndicatorModelList.Skip(pageSize_selected * (pageNum_selected - 1)).Take(pageSize_selected).ToList();
        }
        public void bindDgvUnselected()
        {
            dgv_unselected.DataSource = new List<IndicatorForTemplateModel>();
            pagingPanel_unselected.setDetail(unselectedIndicatorModelList.Count());
            dgv_unselected.DataSource = unselectedIndicatorModelList.Skip(pageSize_unselect * (pageNum_unselect - 1)).Take(pageSize_unselect).ToList();
        }

        private void btn_moveToUnselected_Click(object sender, EventArgs e)
        {
            List<int> checkedIndicatorId = new List<int>();
            foreach (DataGridViewRow row in dgv_selected.Rows)
            {
                if (row.Cells[0].Value.ToString() == "True")
                {
                    checkedIndicatorId.Add((int)row.Cells[2].Value);
                }
            }
            if (checkedIndicatorId.Count == 0) { MessageBoxEx.Show("您没有选中任何指标", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                foreach (var indicatorId in checkedIndicatorId)
                {
                    moveIndicator(selectedIndicatorModelList, unselectedIndicatorModelList, indicatorId);
                }
                chk_selected.Checked = false;
                bindDgv();
            }
        }

        private void btn_moveToSelected_Click(object sender, EventArgs e)
        {
            List<int> checkedIndicatorId = new List<int>();
            foreach (DataGridViewRow row in dgv_unselected.Rows)
            {
                if (row.Cells[0].Value.ToString() == "True")
                {
                    checkedIndicatorId.Add((int)row.Cells[2].Value);
                }
            }
            if (checkedIndicatorId.Count == 0) { MessageBoxEx.Show("您没有选中任何指标", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            else
            {
                foreach (var indicatorId in checkedIndicatorId)
                {
                    moveIndicator(unselectedIndicatorModelList, selectedIndicatorModelList, indicatorId);
                }
                chk_unselect.Checked = false;
                bindDgv();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> selectedIndicatorIdList = selectedIndicatorModelList.Select(i => i.indicatorId).ToList();
                //IndicatorTemplateMapCache.addCache(templateId, selectedIndicatorIdList);
                MessageBoxEx.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("保存失败。" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewX dgv = sender as DataGridViewX;
                int indicatorId = (int)dgv.Rows[e.RowIndex].Cells[2].Value;
                swapIndicatro(dgv, indicatorId);
            }
        }
        private void swapIndicatro(DataGridViewX dgv, int indicatorId)
        {
            if (dgv.Name == "dgv_selected")//已选-》待选
            {
                moveIndicator(selectedIndicatorModelList, unselectedIndicatorModelList, indicatorId);
            }
            else//待选=》已选
            {
                moveIndicator(unselectedIndicatorModelList, selectedIndicatorModelList, indicatorId);
            }

            bindDgv();
        }
        private void moveIndicator(List<IndicatorForTemplateModel> source, List<IndicatorForTemplateModel> target, int sourceIndicatorId)
        {
            var indicatorToMove = source.FirstOrDefault(i => i.indicatorId == sourceIndicatorId);
            if (indicatorToMove != null)
            {
                source.Remove(indicatorToMove);
                target.Add(indicatorToMove);
            }
        }

        /// <summary>
        /// 对外提供选中指标id列表
        /// </summary>
        /// <returns></returns>
        public List<int> getSelectedIndicatorIdList()
        {
            return selectedIndicatorModelList.Select(i => i.indicatorId).ToList();
        }
        /// <summary>
        /// 对外提供清空全部指标项的方法
        /// </summary>
        public void cleanIndicatorList()
        {
            selectedIndicatorModelList.Clear();
            bindDgvSelected();
            unselectedIndicatorModelList.Clear();
            bindDgvUnselected();
        }

        private void dgv_selected_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //绘制行序号
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv_selected.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv_selected.RowHeadersDefaultCellStyle.Font,
                   rectangle, dgv_selected.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgv_unselected_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //绘制行序号
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv_unselected.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv_unselected.RowHeadersDefaultCellStyle.Font,
                   rectangle, dgv_unselected.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        public void doPagging(int pageNum, int pageSize)
        {
            if (sti_selected.IsSelected)
            {
                this.pageSize_selected = pageSize;
                this.pageNum_selected = pageNum;
                bindDgvSelected();
            }
            if (sti_unselected.IsSelected)
            {
                this.pageSize_unselect = pageSize;
                this.pageNum_unselect = pageNum;
                bindDgvUnselected();
            }
        }

        private void chk_selected_CheckedChanged(object sender, EventArgs e)
        {
            selectedAll(dgv_selected);
        }

        private void chk_unselect_CheckedChanged(object sender, EventArgs e)
        {
            selectedAll(dgv_unselected);
        }
        /// <summary>
        /// 表格当前页全选
        /// </summary>
        /// <param name="dgv"></param>
        private void selectedAll(DataGridView dgv)
        {
            foreach (DataGridViewRow dgvr in dgv.Rows)
            {
                dgvr.Cells[0].Value = true;
            }
        }
    }
}
