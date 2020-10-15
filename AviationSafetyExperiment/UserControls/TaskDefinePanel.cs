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
using AviationSafetyExperiment.Model;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskDefinePanel : UserControl
    {
        private int taskType = -1;

        public List<int> indicatorIdList;
        public Dictionary<int, List<int>> brandModelIdDic = new Dictionary<int, List<int>>();
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskDefinePanel()
        {
            InitializeComponent();
        }

        public void init()
        {
            its.init();
            cbb_taskClass.SelectedValueChanged -= cbb_taskClass_SelectedValueChanged;
            cbb_taskClass.DisplayMember = "codeName";
            cbb_taskClass.ValueMember = "id";
            cbb_taskClass.DataSource = CodeCache.getClass();
            cbb_taskClass.SelectedValueChanged += cbb_taskClass_SelectedValueChanged;

            foreach (User user in User.list)
            {
                ccb_taskExecutor.Items.Add(user);
            }
            ccb_taskExecutor.ValueMember = "id";
            ccb_taskExecutor.DisplayMember = "name";
        }

        public void createTask()
        {
            indicatorIdList = its.getSelectedIndicatorIdList();
            if (indicatorIdList.Count == 0)
            {
                MessageBoxEx.Show("请选择指标模板，并从中选取要测试的指标", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Tb_taskInfo task = new Db.Entity.Tb_taskInfo();
            task.percent = 0;
            task.taskClass = (int)cbb_taskClass.SelectedValue;
            task.taskCode = txt_taskCode.Text.Trim();
            task.taskExecutor = ccb_taskExecutor.Text;//txt_taskExecutor.Text.Trim();
            task.taskName = txt_taskName.Text.Trim();
            task.taskType = taskType;
            task.taskState = (int)TaskStateEnum.Created;
            task.createTime = DateTime.Now;
            try
            {
                TaskCache.createTask(task, indicatorIdList, brandModelIdDic);
                MessageBox.Show("任务创建成功", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("任务创建失败，原因是：" + ex.Message, "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                //生成任务编号
                txt_taskCode.Text = (cbb_taskClass.SelectedItem as Tb_code).codeName + "-" +DateTime.Now.ToString("yyyyMMddHHmmss");
                //清空之前所选的品牌型号、及任务类型（单多）
                brandModelIdDic = new Dictionary<int, List<int>>();
                lbl_brandModel.Text = string.Empty;
                taskType = -1;
                lbl_taskType.Text = string.Empty;
                //清空模板所选
                its.cleanIndicatorList();

                its.cbb_classId = (int)cbb_taskClass.SelectedValue;
                its.cbb_className= (cbb_taskClass.SelectedItem as Tb_code).codeName;
                its.bindCbbExitsTemplate();//切换分类时重新绑定已有模板下拉列表
                //its.getTemplateIndicators();
            }
        }
    }
}
