using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using AviationSafetyExperiment.Model;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
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
    public partial class IndicatorManage : DevComponents.DotNetBar.Office2007Form
    {
        public List<Tb_indicator> indicatorList = new List<Tb_indicator>();
        public List<IndicatorModel> indicatorModels = new List<IndicatorModel>();

        public IndicatorManage()
        {
            InitializeComponent();
        }

        private void IndicatorManage_Shown(object sender, EventArgs e)
        {
            getIndicator();
            dgv_indicator.DataSource = indicatorModels;
            bindCheckBox();
        }

        private void bindCheckBox()
        {
            var classList = CodeCache.getClass();
            foreach (var classItem in classList)
            {
                CheckBox chk = new CheckBox();
                chk.Name = classItem.codeName;
                chk.Text = classItem.codeName;
                chk.Tag = classItem.codeId;
                chk.Checked = true;
                chk.CheckedChanged += chk_valueChange;
                tlp.Controls.Add(chk);
            }
        }

        /// <summary>
        /// 从缓存层获取指标
        /// </summary>
        private void getIndicator()
        {
            indicatorList = IndicatorCache.getCache();
            var classList = CodeCache.getClass();
            indicatorModels = (from indicator in indicatorList
                               from classType in classList
                               where indicator.classId == classType.codeId
                               select new IndicatorModel()
                               {
                                   indicatorId = indicator.indicatorId,
                                   classId=indicator.classId,
                                   className = classType.codeName,
                                   indicatorName = indicator.indicatorName,
                                   indicatorDesc = indicator.indicatorDesc,
                                   isObsolete = indicator.isObsolete == 1 ? "已废弃" : "生效中"
                               }).ToList();
        }

        /// <summary>
        /// 筛选本地保存的指标
        /// </summary>
        private void filtrateIndicator()
        {
            List<int> checkedClassIdList = new List<int>();
            foreach (CheckBox chk in tlp.Controls)
            {
                if (chk.Checked)
                {
                    checkedClassIdList.Add((int)chk.Tag);
                }
            }
            List<string> checkedObsoleteList = new List<string>();
            foreach (CheckBoxX chk in panelObsolete.Controls)
            {
                if (chk.Checked)
                {
                    checkedObsoleteList.Add(chk.Text);
                }
            }
            var datasource = indicatorModels.Where(i => checkedClassIdList.Contains(i.classId) && checkedObsoleteList.Contains(i.isObsolete)).ToList();
            dgv_indicator.DataSource = datasource;

        }

        private void btn_addIndicator_Click(object sender, EventArgs e)
        {
            IndicatorEdit ie = new AviationSafetyExperiment.IndicatorEdit();
            ie.ShowDialog(this);
        }

        private void btn_editIndicator_Click(object sender, EventArgs e)
        {
            if (dgv_indicator.SelectedRows.Count == 0)
            {
                MessageBoxEx.Show("请先选择一个指标");
            }
            else
            {
                IndicatorEdit ie = new AviationSafetyExperiment.IndicatorEdit();
                ie.indicator = indicatorList.FirstOrDefault(i => i.indicatorId == (int)dgv_indicator.SelectedRows[0].Cells[0].Value);
                ie.ShowDialog(this);
                getIndicator();
                filtrateIndicator();
            }
        }

        private void chk_valueChange(object sender, EventArgs e)
        {
            filtrateIndicator();
        }
    }
}
