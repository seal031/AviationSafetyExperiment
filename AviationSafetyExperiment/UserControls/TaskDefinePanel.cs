using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using DevComponents.DotNetBar;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskDefinePanel : UserControl
    {
        private int taskType = -1;

        public List<int> indicatorIdList;
        public Dictionary<int, List<int>> brandModelIdDic = new Dictionary<int, List<int>>();

        public TaskDefinePanel()
        {
            InitializeComponent();
        }

        public void init()
        {
            its.init();
            cbb_taskClass.DisplayMember = "codeName";
            cbb_taskClass.ValueMember = "id";
            cbb_taskClass.DataSource = CodeCache.getClass();
        }

        public void createTask()
        {
            Tb_taskInfo task = new Db.Entity.Tb_taskInfo();
            task.percent = 0;
            task.taskClass = (int)cbb_taskClass.SelectedValue;
            task.taskCode = txt_taskCode.Text.Trim();
            task.taskExecutor = txt_taskExecutor.Text.Trim();
            task.taskName = txt_taskName.Text.Trim();
            task.taskType = taskType;
            task.taskState = 5001;
            task.createTime = DateTime.Now;
            indicatorIdList = its.getSelectedIndicatorIdList();
            TaskCache.createTask(task, indicatorIdList,brandModelIdDic);
        }

        private void btn_pickBrandModel_Click(object sender, EventArgs e)
        {
            if (cbb_taskClass.SelectedItem == null)
            {
                MessageBoxEx.Show("请先选择测试分类");
            }
            else
            {
                BrandModelSelector bms = new AviationSafetyExperiment.BrandModelSelector();
                bms.classId = (int)cbb_taskClass.SelectedValue;
                bms.selectedDic = brandModelIdDic;
                bms.initTree();
                bms.ShowDialog(this);
                brandModelIdDic = bms.selectedDic;
                showBrandModelText();
            }
        }

        private void showBrandModelText()
        {
            List<string> brandModelTextList = new List<string>();
            foreach (int brandId in brandModelIdDic.Keys)
            {
                var brand = CodeCache.getBrand().FirstOrDefault(c => c.id == brandId);
                if (brand != null)
                {
                    foreach (int modelId in brandModelIdDic[brandId])
                    {
                        var model = CodeCache.getModel().FirstOrDefault(c => c.id == modelId);
                        if (model != null)
                        {
                            brandModelTextList.Add(brand.codeName+"    "+model.codeName);
                        }
                    }
                }
            }
            lbl_brandModel.Text = string.Join(Environment.NewLine, brandModelTextList);

            if (brandModelIdDic.Keys.Count == 0) { lbl_taskType.Text = ""; }
            else if (brandModelIdDic.Keys.Count == 1)
            {
                lbl_taskType.Text = "单品牌测试";
                taskType = 4001;
            }
            else
            {
                lbl_taskType.Text = "多品牌测试";
                taskType = 4002;
            }
        }

        private void btn_createTask_Click(object sender, EventArgs e)
        {
            createTask();
        }

        private void cbb_taskClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb_taskClass.SelectedValue != null)
            {
                its.cbb_classId = (int)cbb_taskClass.SelectedValue;
                its.bindCbbExitsTemplate();//切换分类时重新绑定已有模板下拉列表
            }
        }
    }
}
