using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
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
    public partial class IndicatorEdit : DevComponents.DotNetBar.Office2007Form
    {
        public Tb_indicator indicator;
        private bool readOnly = false;

        public IndicatorEdit(bool _readOnly = false)
        {
            InitializeComponent();
            this.readOnly = _readOnly;
            if (readOnly)
            {
                cbb_class.Enabled = false;
                cbb_detection.Enabled = false;
                cbb_subDetection.Enabled = false;
                txt_indicatorName.ReadOnly = true;
                txt_indicatorDesc.ReadOnly = true;
                txt_indicatorInstr.ReadOnly = true;
                chk_isObsolete.Enabled = false;
                btn_save.Text = "关闭";
                this.Text = "指标信息详情";
            }
            else
            {
                errorProvider1.SetError(txt_indicatorName, "指标名称是必填项");
                errorProvider1.SetError(txt_indicatorDesc, "指标描述是必填项");
            }
        }

        private void IndicatorEdit_Shown(object sender, EventArgs e)
        {
            bindCbb();
            if (indicator != null)
            {
                cbb_class.SelectedValue = indicator.classId;
                cbb_detection.SelectedValue = indicator.detectionId;
                cbb_subDetection.SelectedValue = indicator.subDetectionId;
                txt_indicatorName.Text = indicator.indicatorName;
                txt_indicatorDesc.Text = indicator.indicatorDesc;
                txt_indicatorInstr.Text = indicator.indicatorInstr;
                chk_isObsolete.Checked = indicator.isObsolete == 1 ? true : false;
            }
        }

        private void bindCbb()
        {
            List<Tb_code> classes = CodeCache.getClass();
            cbb_class.DataSource = classes;
            cbb_class.DisplayMember = "codeName";
            cbb_class.ValueMember = "id";
           
        }

        /// <summary>
        /// 保存/编辑 指标至数据库
        /// </summary>
        private void saveIndicator()
        {
            if (indicator == null)
            {
                indicator = new Tb_indicator();
            }
            setIndicator();
            IndicatorCache.addCache(indicator);
        }

        private void setIndicator()
        {
            indicator.classId = (int)cbb_class.SelectedValue;
            indicator.detectionId = (int)cbb_detection.SelectedValue;
            indicator.subDetectionId = (int)cbb_subDetection.SelectedValue;
            indicator.indicatorName = txt_indicatorName.Text.Trim();
            indicator.indicatorDesc = txt_indicatorDesc.Text.Trim();
            indicator.indicatorInstr = txt_indicatorInstr.Text.Trim();
            indicator.isObsolete = chk_isObsolete.Checked ? 1 : 0;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (readOnly == false)
            {
                saveIndicator();
            }
            this.Close();
        }

        private void cbb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_detection.DataSource = null;
            if (cbb_class.DataSource != null)
            {
                List<Tb_code> detections = CodeCache.getDetection().Where(c => c.parentId == ((Tb_code)cbb_class.SelectedItem).id).ToList();
                cbb_detection.DataSource = detections;
                cbb_detection.DisplayMember = "codeName";
                cbb_detection.ValueMember = "id";
            }
        }

        private void cbb_detection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_subDetection.DataSource = null;
            if (cbb_detection.DataSource != null)
            {
                List<Tb_code> subDetections = CodeCache.getSubDetection().Where(c => c.parentId == ((Tb_code)cbb_detection.SelectedItem).id).ToList();
                cbb_subDetection.DataSource = subDetections;
                cbb_subDetection.DisplayMember = "codeName";
                cbb_subDetection.ValueMember = "id";
            }
        }
    }
}
