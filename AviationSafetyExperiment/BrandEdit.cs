using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using DevComponents.DotNetBar;
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
    public partial class BrandEdit : DevComponents.DotNetBar.Office2007Form
    {
        public Tb_code classCode;
        public Tb_code brandCode;
        public Tb_code modelCode;
        public CodeTypeEnum codeType;

        public BrandEdit()
        {
            InitializeComponent();
        }

        private void BrandEdit_Shown(object sender, EventArgs e)
        {
            switch (codeType)
            {
                case CodeTypeEnum.Brand://针对品牌
                    lbl_brand.Visible = false;
                    lbl_brandValue.Visible = false;
                    if (classCode != null)
                    {
                        lbl_classValue.Text = classCode.codeName;
                    }
                    lbl_value.Text = "品牌：";
                    if (brandCode == null)//新增品牌
                    {
                        this.Text = "新增品牌";
                    }
                    else//编辑品牌
                    {
                        this.Text = "编辑品牌";
                        txt_value.Text = brandCode.codeName;
                    }
                    break;
                case CodeTypeEnum.Model://针对型号
                    if (classCode != null)
                    {
                        lbl_classValue.Text = classCode.codeName;
                    }
                    if (brandCode != null)
                    {
                        lbl_brandValue.Text = brandCode.codeName;
                    }
                    lbl_value.Text = "型号：";
                    if (modelCode == null)//新增型号
                    {
                        this.Text = "新增型号";
                    }
                    else//编辑型号
                    {
                        this.Text = "编辑型号";
                        txt_value.Text = modelCode.codeName;
                    }
                    break;
                case CodeTypeEnum.Class://针对分类
                    lbl_class.Visible = false;
                    lbl_classValue.Visible = false;
                    lbl_brand.Visible = false;
                    lbl_brandValue.Visible = false;
                    lbl_value.Text = "分类：";
                    if (classCode == null)//新增分类
                    {
                        this.Text = "新增分类";
                    }
                    else//编辑分类
                    {
                        this.Text = "编辑分类";
                        txt_value.Text = classCode.codeName;
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Trim() == string.Empty)
            {
                MessageBoxEx.Show("名称不能为空，请输入一个名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                switch (codeType)
                {
                    case CodeTypeEnum.Brand:
                        if (brandCode == null)
                        {
                            brandCode = new Tb_code();
                            brandCode.id = CodeCache.getBrand().Count == 0 ? 1000 : CodeCache.getBrand().Max(c => c.id) + 1;//品牌默认从1000开始
                            brandCode.codeType = (int)CodeTypeEnum.Brand;
                            brandCode.parentId = classCode.id;
                        }
                        brandCode.codeName = txt_value.Text.Trim();
                        CodeCache.addCache(brandCode);
                        break;
                    case CodeTypeEnum.Model:
                        if (modelCode == null)
                        {
                            modelCode = new Tb_code();
                            modelCode.id = CodeCache.getModel().Count == 0 ? 2000 : CodeCache.getModel().Max(c => c.id) + 1;//型号从2000开始
                            modelCode.codeType = (int)CodeTypeEnum.Model;
                            modelCode.parentId = brandCode.id;
                        }
                        modelCode.codeName = txt_value.Text.Trim();
                        CodeCache.addCache(modelCode);
                        break;
                    case CodeTypeEnum.Class:
                        if (classCode == null)
                        {
                            classCode = new Db.Entity.Tb_code();
                            classCode.id = CodeCache.getClass().Count == 0 ? 3000 : CodeCache.getClass().Max(c => c.id) + 1;//分类默认从3000开始
                            classCode.codeType = (int)CodeTypeEnum.Class;
                        }
                        classCode.codeName = txt_value.Text.Trim();
                        CodeCache.addCache(classCode);
                        break;
                    default:
                        break;
                }
                this.Close();
            }
        }
    }
}
