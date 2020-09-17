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
using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.Model;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using System.Diagnostics;
using System.Threading;

namespace AviationSafetyExperiment.UserControls
{
    public partial class IndicatorTemplateSelecter : UserControl,IPagging
    {
        public int cbb_classId;
        public string cbb_className;
        
        private List<Tb_indicator> indicatorList;
        private List<Tb_code> classList;
        private List<Tb_code> detectionList;
        private List<Tb_code> subDetectionList;
        #region 分页
        int pageSize_selected = 10;//默认每页10条
        int pageNum_selected = 1;//默认首页
        int pageSize_unselect = 10;//默认每页10条
        int pageNum_unselect = 1;//默认首页
        #endregion

        IEnumerable<Tb_indicatorTemplate> templateList = new List<Tb_indicatorTemplate>();
        /// <summary>
        /// 模板中的已选指标
        /// </summary>
        List<IndicatorForTemplateModel> selectedIndicatorModelList = new List<IndicatorForTemplateModel>();
        /// <summary>
        /// 模板中的待选指标
        /// </summary>
        List<IndicatorForTemplateModel> unselectedIndicatorModelList = new List<IndicatorForTemplateModel>();

        [Browsable(true)]
        [Description("是否处于模板管理界面"), Category("自定义"), DefaultValue(true)]
        public bool isManage { get; set; } = true;//是否处于指标模板管理界面中，用于控制控件状态和行为
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public IndicatorTemplateSelecter()
        {
            InitializeComponent();
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
            buildClasss();
            stc.SelectedTab = sti_selected;
            if (isManage == false)
            {
                groupPanel3.Text = "指标选择";
                btn_showNewTemplatePanel.Visible = false;
                lbl_class.Visible = false;
                cbb_class.Visible = false;
                btn_save.Visible = false;
                groupPanel3.Height = cbb_exitsTemplate.Height + 40;
                lbl_exitsTemplate.Left = lbl_class.Left;
                lbl_exitsTemplate.Top = lbl_class.Top;
                cbb_exitsTemplate.Left = cbb_class.Left;
                cbb_exitsTemplate.Top = cbb_class.Top;
            }
        }
        private void getAllList()
        {
            indicatorList = IndicatorCache.getCache();
            classList = CodeCache.getClass();
            detectionList = CodeCache.getDetection();
            subDetectionList = CodeCache.getSubDetection();
        }

        private void buildClasss()
        {
            cbb_class.SelectedIndexChanged -= cbb_class_SelectedIndexChanged;
            cbb_class.DisplayMember = "codeName";
            cbb_class.ValueMember = "id";
            cbb_class.DataSource = classList;
            cbb_class.SelectedValue = 0;
            cbb_class.SelectedIndexChanged += cbb_class_SelectedIndexChanged;
        }

        private void cbb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isManage == true)
            {
                cbb_classId = (int)cbb_class.SelectedValue;
                cbb_className = (cbb_class.SelectedItem as Tb_code).codeName;
            }
            bindCbbExitsTemplate();
        }

        public void bindCbbExitsTemplate()
        {
            cbb_exitsTemplate.SelectedIndexChanged -= cbb_exitsTemplate_SelectedIndexChanged;
            templateList = TemplateCache.getCache().Where(t => t.classId == cbb_classId).ToList();
            cbb_exitsTemplate.DisplayMember = "templateName";
            cbb_exitsTemplate.ValueMember = "id";
            cbb_exitsTemplate.DataSource = templateList;
            cbb_exitsTemplate.SelectedValue = 0;
            cbb_exitsTemplate.SelectedIndexChanged += cbb_exitsTemplate_SelectedIndexChanged;
        }

        private void cbb_exitsTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTemplateIndicators();
        }

        public void getTemplateIndicators()
        {
            progressBar.Visible = true;
            cbb_exitsTemplate.Enabled = false;
            initPaggingParams();
            IProgress<string> progress = new Progress<string>(value => {
                progressBar.Text = value;
            });
            int templateId = (cbb_exitsTemplate.SelectedValue == null ? 0 : (int)cbb_exitsTemplate.SelectedValue);
            var data = getData(templateId, cbb_className, progress);
            if (data.IsCompleted)
            {
                data.Wait();
            }
            //bindDgv();
        }

        private async Task getData(int templateId,string className,IProgress<string> progress)
        {
            //获取某分类下所有指标
            var anyClassIndicatorList = IndicatorCache.getCache().Where(i => i.classId == cbb_classId);
            progress.Report("获取全部指标");
            //获取所选模板的已选指标
            var selectedIndicatorList = IndicatorTemplateMapCache.getCache().Where(i => i.templateId == templateId);
            progress.Report("获取已选指标");
            await Task.Factory.StartNew(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var childOne = Task.Factory.StartNew(() =>
                {
                    //生成已选指标model对象列表
                    selectedIndicatorModelList = (from indicatorMap in selectedIndicatorList
                                                  from indicator in anyClassIndicatorList
                                                  //from classType in classList
                                                  from detection in detectionList
                                                  from subDetection in subDetectionList
                                                  where indicatorMap.indicatorId == indicator.id// && indicator.classId == classType.id 
                                                  && indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                                                  select new IndicatorForTemplateModel()
                                                  {
                                                      classId = indicator.classId,
                                                      className = className,//classType.codeName,
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
                },TaskCreationOptions.AttachedToParent);
                var childTwo = Task.Factory.StartNew(() =>
                {
                    //已选指标id列表
                    var selectedIndicatorIdList = selectedIndicatorList.Select(i => i.indicatorId).ToList();
                    //计算出所选模板的待选指标
                    var unselectIndicatorList = anyClassIndicatorList.Where(ii => selectedIndicatorIdList.Contains(ii.id) == false).ToList();
                    //unselectedIndicatorModelList = anyClassIndicatorList.AsEnumerable<Tb_indicator>().Except<Tb_indicator>(selectedIndicatorModelList);
                    unselectedIndicatorModelList = (from unselectedIndicator in unselectIndicatorList
                                                    from indicator in anyClassIndicatorList
                                                    //from classType in classList
                                                    from detection in detectionList
                                                    from subDetection in subDetectionList
                                                    where unselectedIndicator.id == indicator.id //&& indicator.classId == classType.id 
                                                    && indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                                                    select new IndicatorForTemplateModel()
                                                    {
                                                        classId = indicator.classId,
                                                        className = className,// classType.codeName,
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
                },TaskCreationOptions.AttachedToParent);
                sw.Stop();
                Debug.WriteLine(sw.ElapsedMilliseconds);
                progress.Report("指标获取中……");
            });
            bindDgv();
            progressBar.Visible = false;
            cbb_exitsTemplate.Enabled = true;
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

        private void btn_showNewTemplatePanel_Click(object sender, EventArgs e)
        {
            if (cbb_class.SelectedValue == null)
            {
                MessageBoxEx.Show("请先选择所属分类", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                pnl_addTempla.Visible = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            pnl_addTempla.Visible = false;
        }

        private void btn_addNewTemplate_Click(object sender, EventArgs e)
        {
            if (txt_newTemplateName.Text.Trim() == string.Empty)
            {
                MessageBoxEx.Show("请先选择所属分类", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Tb_indicatorTemplate template = new Db.Entity.Tb_indicatorTemplate();
                template.classId = cbb_classId;
                template.createDatetime = DateTime.Now.ToLocalTime(); ;
                template.templateName = txt_newTemplateName.Text.Trim();
                TemplateCache.addCache(template);
                pnl_addTempla.Visible = false;
                bindCbbExitsTemplate();
                cbb_exitsTemplate.SelectedItem = template;
            }
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
                int templateId = (int)cbb_exitsTemplate.SelectedValue;
                List<int> selectedIndicatorIdList = selectedIndicatorModelList.Select(i => i.indicatorId).ToList();
                IndicatorTemplateMapCache.addCache(templateId, selectedIndicatorIdList);
                MessageBoxEx.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("保存失败。"+ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void swapIndicatro(DataGridViewX dgv,int indicatorId)
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
        private void moveIndicator(List<IndicatorForTemplateModel> source,List<IndicatorForTemplateModel> target,int sourceIndicatorId)
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
