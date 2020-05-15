using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents;
using DevComponents.DotNetBar;
using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;

namespace AviationSafetyExperiment
{
    public partial class BrandManage : DevComponents.DotNetBar.Office2007Form
    {
        public BrandManage()
        {
            InitializeComponent();
        }

        private void BrandManage_Shown(object sender, EventArgs e)
        {
            loadClass();
        }

        #region 加载listbox
        private void loadClass()
        {
            var classList = CodeCache.getClass().OrderBy(c => c.id);
            ip_class.Items.Clear();
            foreach (var classItem in classList)
            {
                ip_class.Items.Add(classItem.codeName);
            }
        }

        private void loadBrand()
        {
            if (ip_class.SelectedItems.Count > 0)
            {
                var selectedClass = getSelectedClass();
                ip_brand.Items.Clear();
                if (selectedClass != null)
                {
                    var brandList = CodeCache.getBrand().Where(c => c.parentId == selectedClass.id);
                    foreach (var brandItem in brandList)
                    {
                        ip_brand.Items.Add(brandItem.codeName);
                    }
                }
            }
        }

        private void loadModel()
        {
            if (ip_brand.SelectedItems.Count > 0)
            {
                var selectedBrand = getSelectedBrand();
                ip_model.Items.Clear();
                if (selectedBrand != null)
                {
                    var modelList = CodeCache.getModel().Where(c => c.parentId == selectedBrand.id);
                    foreach (var modelItem in modelList)
                    {
                        ip_model.Items.Add(modelItem.codeName);
                    }
                }
            }
        }
        #endregion

        #region 3个listbox中的按钮绑定的事件
        private void ip_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBrand();
        }

        private void ip_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadModel();
        }

        private void ip_class_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editClass();
        }

        private void ip_brand_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editBrand();
        }

        private void ip_model_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editModel();
        }
        #endregion

        #region 新增3种对象的逻辑
        private void btn_addClass_Click(object sender, EventArgs e)
        {
            BrandEdit be = new BrandEdit();
            be.codeType = Db.Entity.CodeTypeEnum.Class;
            be.ShowDialog(this);
            loadClass();
        }

        private void btn_addBrand_Click(object sender, EventArgs e)
        {
            if (ip_class.SelectedItems.Count == 0 )
            {
                MessageBoxEx.Show("请先选择一个分类");
            }
            else
            {
                BrandEdit be = new BrandEdit();
                be.codeType = Db.Entity.CodeTypeEnum.Brand;
                be.classCode = getSelectedClass();
                be.ShowDialog(this);
                loadBrand();
            }

        }

        private void btn_addModel_Click(object sender, EventArgs e)
        {
            if (ip_class.SelectedItems.Count == 0 || ip_brand.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请先选择一个分类和品牌");
            }
            else
            {
                BrandEdit be = new BrandEdit();
                be.codeType = Db.Entity.CodeTypeEnum.Model;
                be.classCode = getSelectedClass();
                be.brandCode = getSelectedBrand();
                be.ShowDialog(this);
                loadModel();
            }
        }
        #endregion

        #region 编辑3种对象的逻辑
        private void btn_editClass_Click(object sender, EventArgs e)
        {
            editClass();
        }

        private void btn_editBrand_Click(object sender, EventArgs e)
        {
            editBrand();
        }

        private void btn_editModel_Click(object sender, EventArgs e)
        {
            editModel();
        }

        private void editClass()
        {
            if (ip_class.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请先选择一个分类");
            }
            else
            {
                BrandEdit be = new BrandEdit();
                be.codeType = CodeTypeEnum.Class;
                be.classCode = getSelectedClass();
                be.ShowDialog(this);
                loadClass();
            }
        }
        private void editBrand()
        {
            if (ip_class.SelectedItems.Count == 0 || ip_brand.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请先选择一个分类和品牌");
            }
            else
            {
                BrandEdit be = new BrandEdit();
                be.codeType = CodeTypeEnum.Brand;
                be.classCode = getSelectedClass();
                be.brandCode = getSelectedBrand();
                be.ShowDialog(this);
                loadBrand();
            }
        }
        private void editModel()
        {
            if (ip_brand.SelectedItems.Count == 0 || ip_model.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("请先选择一个品牌和型号");
            }
            else
            {
                BrandEdit be = new BrandEdit();
                be.codeType = CodeTypeEnum.Model;
                be.classCode = getSelectedClass();
                be.brandCode = getSelectedBrand();
                be.modelCode = getSelectedModel();
                be.ShowDialog(this);
                loadModel();
            }
        }
        #endregion

        private Tb_code getSelectedClass()
        {
            if (ip_class.SelectedItem != null)
            {
                return CodeCache.getClass().FirstOrDefault(c => c.codeName == ip_class.SelectedItem.ToString());
            }
            else
            {
                return null;
            }
        }
        private Tb_code getSelectedBrand()
        {
            var selectedClass = getSelectedClass();
            if (selectedClass != null)
            {
                return CodeCache.getBrand().FirstOrDefault(c => c.codeName == ip_brand.SelectedItem.ToString() && c.parentId == selectedClass.id);
            }
            else
            {
                return null;
            }
        }
        private Tb_code getSelectedModel()
        {
            var selectedBrand = getSelectedBrand();
            if (selectedBrand != null)
            {
                return CodeCache.getModel().FirstOrDefault(c => c.codeName == ip_model.SelectedItem.ToString() && c.parentId == selectedBrand.id);
            }
            else
            {
                return null;
            }
        }
    }
}
