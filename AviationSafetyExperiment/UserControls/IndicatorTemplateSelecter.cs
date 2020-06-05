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

namespace AviationSafetyExperiment.UserControls
{
    public partial class IndicatorTemplateSelecter : UserControl
    {
        public int cbb_classId;

        private List<Tb_indicator> indicatorList;
        private List<Tb_code> classList;
        private List<Tb_code> detectionList;
        private List<Tb_code> subDetectionList;

        List<Tb_indicatorTemplate> templateList = new List<Tb_indicatorTemplate>();
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

        public IndicatorTemplateSelecter()
        {
            InitializeComponent();
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
            cbb_class.DisplayMember = "codeName";
            cbb_class.ValueMember = "id";
            cbb_class.DataSource = classList;
        }
        private void cbb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isManage == true)
            {
                cbb_classId = (int)cbb_class.SelectedValue;
            }
            bindCbbExitsTemplate();
        }

        public void bindCbbExitsTemplate()
        {
            templateList = TemplateCache.getCache().Where(t => t.classId == cbb_classId).ToList();
            cbb_exitsTemplate.DisplayMember = "templateName";
            cbb_exitsTemplate.ValueMember = "id";
            cbb_exitsTemplate.DataSource = templateList;
            cbb_exitsTemplate.SelectedValue = 0;
        }

        private void cbb_exitsTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            getTemplateIndicators();
        }

        private void getTemplateIndicators()
        {
            var anyClassIndicatorList = IndicatorCache.getCache().Where(i => i.classId == cbb_classId).ToList();//获取某分类下所有指标
            //获取所选模板的已选指标
            var selectedIndicatorList = IndicatorTemplateMapCache.getCache().Where(i => i.templateId == (cbb_exitsTemplate.SelectedValue == null ? 0 : (int)cbb_exitsTemplate.SelectedValue));
            //生成已选指标model对象列表
            selectedIndicatorModelList = (from indicatorMap in selectedIndicatorList
                                          from indicator in indicatorList
                                          from classType in classList
                                          from detection in detectionList
                                          from subDetection in subDetectionList
                                          where indicatorMap.indicatorId == indicator.id && indicator.classId == classType.id && indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                                          select new IndicatorForTemplateModel()
                                          {
                                              classId = indicator.classId,
                                              className = classType.codeName,
                                              detectionId = detection.id,
                                              detectionName = detection.codeName,
                                              indicatorDesc = indicator.indicatorDesc,
                                              indicatorId = indicator.id,

                                              indicatorName = indicator.indicatorName,
                                              isObsolete = indicator.isObsolete == 1 ? "已废弃" : "生效中",
                                              isSelected = false,
                                              subDetectionId = subDetection.id,
                                              subDetectionName = subDetection.codeName,
                                          }).ToList();

            //已选指标id列表
            var selectedIndicatorIdList = selectedIndicatorList.Select(i => i.id);
            //计算出所选模板的待选指标
            var unselectIndicatorList = anyClassIndicatorList.Where(ii => selectedIndicatorIdList.Contains(ii.id) == false);
            //unselectedIndicatorModelList = anyClassIndicatorList.AsEnumerable<Tb_indicator>().Except<Tb_indicator>(selectedIndicatorModelList);
            unselectedIndicatorModelList = (from unselectedIndicator in unselectIndicatorList
                                            from indicator in indicatorList
                                            from classType in classList
                                            from detection in detectionList
                                            from subDetection in subDetectionList
                                            where unselectedIndicator.id == indicator.id && indicator.classId == classType.id && indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                                            select new IndicatorForTemplateModel()
                                            {
                                                classId = indicator.classId,
                                                className = classType.codeName,
                                                detectionId = detection.id,
                                                detectionName = detection.codeName,
                                                indicatorDesc = indicator.indicatorDesc,
                                                indicatorId = indicator.id,
                                                indicatorName = indicator.indicatorName,
                                                isObsolete = indicator.isObsolete == 1 ? "已废弃" : "生效中",
                                                isSelected = false,
                                                subDetectionId = subDetection.id,
                                                subDetectionName = subDetection.codeName,
                                            }).ToList();
            bindDgv();
        }

        private void bindDgv()
        {
            dgv_selected.DataSource = new List<IndicatorForTemplateModel>();
            dgv_selected.DataSource = selectedIndicatorModelList;
            dgv_unselected.DataSource = new List<IndicatorForTemplateModel>();
            dgv_unselected.DataSource = unselectedIndicatorModelList;
        }

        private void btn_showNewTemplatePanel_Click(object sender, EventArgs e)
        {
            pnl_addTempla.Visible = true;
        }

        private void btn_addNewTemplate_Click(object sender, EventArgs e)
        {
            Tb_indicatorTemplate template = new Db.Entity.Tb_indicatorTemplate();
            template.classId = cbb_classId;
            template.createDatetime = DateTime.Now.ToLocalTime(); ;
            template.templateName = txt_newTemplateName.Text.Trim();
            TemplateCache.addCache(template);
            pnl_addTempla.Visible = false;
            bindCbbExitsTemplate();
        }

        private void btn_moveToUnselected_Click(object sender, EventArgs e)
        {
            List<int> checkedIndicatorId = new List<int>();
            foreach (DataGridViewRow row in dgv_selected.Rows)
            {
                if (row.Cells[1].Value.ToString() == "True")
                {
                    checkedIndicatorId.Add((int)row.Cells[2].Value);
                }
            }
            if (checkedIndicatorId.Count == 0) { MessageBoxEx.Show("您没有选中任何指标"); }
            else
            {
                foreach (var indicatorId in checkedIndicatorId)
                {
                    moveIndicator(selectedIndicatorModelList, unselectedIndicatorModelList, indicatorId);
                }
            }
            bindDgv();
        }

        private void btn_moveToSelected_Click(object sender, EventArgs e)
        {
            List<int> checkedIndicatorId = new List<int>();
            foreach (DataGridViewRow row in dgv_unselected.Rows)
            {
                if (row.Cells[1].Value.ToString() == "True")
                {
                    checkedIndicatorId.Add((int)row.Cells[2].Value);
                }
            }
            if (checkedIndicatorId.Count == 0) { MessageBoxEx.Show("您没有选中任何指标"); }
            else
            {
                foreach (var indicatorId in checkedIndicatorId)
                {
                    moveIndicator(unselectedIndicatorModelList, selectedIndicatorModelList, indicatorId);
                }
            }
            bindDgv();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int templateId = (int)cbb_exitsTemplate.SelectedValue;
            List<int> selectedIndicatorIdList = selectedIndicatorModelList.Select(i => i.indicatorId).ToList();
            IndicatorTemplateMapCache.addCache(templateId, selectedIndicatorIdList);
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
    }
}
