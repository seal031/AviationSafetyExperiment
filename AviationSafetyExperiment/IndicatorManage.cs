using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;
using AviationSafetyExperiment.Model;
using DevComponents.AdvTree;
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
        List<Tb_code> classList = CodeCache.getClass();
        List<Tb_code> detectionList = CodeCache.getDetection();
        List<Tb_code> subDetectionList = CodeCache.getSubDetection();

        public IndicatorManage()
        {
            InitializeComponent();
        }

        private void IndicatorManage_Shown(object sender, EventArgs e)
        {
            buildTree();

            getIndicator();
            dgv_indicator.DataSource = indicatorModels;
            bindCheckBox();


            initIts();
        }


        #region 指标细节tab
        private void bindCheckBox()
        {
            var classList = CodeCache.getClass();
            foreach (var classItem in classList)
            {
                CheckBox chk = new CheckBox();
                chk.Name = classItem.codeName;
                chk.Text = classItem.codeName;
                chk.Tag = classItem.id;
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
            classList = CodeCache.getClass();
            detectionList = CodeCache.getDetection();
            subDetectionList = CodeCache.getSubDetection();
            indicatorModels = (from indicator in indicatorList
                               from classType in classList
                               from detection in detectionList
                               from subDetection in subDetectionList
                               where indicator.classId == classType.id && indicator.detectionId == detection.id && indicator.subDetectionId == subDetection.id
                               select new IndicatorModel()
                               {
                                   indicatorId = indicator.id,
                                   classId = indicator.classId,
                                   className = classType.codeName,
                                   detectionId = indicator.detectionId,
                                   detectionName = detection.codeName,
                                   subDetectionId = indicator.subDetectionId,
                                   subDetectionName = subDetection.codeName,
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
            getIndicator();
            filtrateIndicator();
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
                ie.indicator = indicatorList.FirstOrDefault(i => i.id == (int)dgv_indicator.SelectedRows[0].Cells[0].Value);
                ie.ShowDialog(this);
                getIndicator();
                filtrateIndicator();
            }
        }

        private void chk_valueChange(object sender, EventArgs e)
        {
            filtrateIndicator();
        }
        #endregion

        #region 检测内容/分项tabl
        private void cms_Opening(object sender, CancelEventArgs e)
        {
            tsmi_edit.Enabled = tree_detection.SelectedNode.Level < 2 ? false : true;//root和分类node不可修改内容
            tsmi_addNew.Enabled = tree_detection.SelectedNode.Level < 3 ? true : false;//检测分项下不可再创建子node
        }
        private void tsmi_addNew_Click(object sender, EventArgs e)
        {
            var node = tree_detection.SelectedNode;
            addNode(node);
        }

        private void tsmi_edit_Click(object sender, EventArgs e)
        {
            var node = tree_detection.SelectedNode;
            editNode(node);
        }
        private void buildTree()
        {
            var classList = CodeCache.getClass();
            var detectionList = CodeCache.getDetection();
            var subDetectionList = CodeCache.getSubDetection();
            foreach (Tb_code classItem in classList)
            {
                var classNode = addNode(rootNode, classItem);
                foreach (Tb_code detectionItem in detectionList.Where(c => c.parentId == classItem.id))
                {
                    var detectionNode = addNode(classNode, detectionItem);
                    foreach (Tb_code subDetectionItem in subDetectionList.Where(c => c.parentId == detectionItem.id))
                    {
                        addNode(detectionNode, subDetectionItem);
                    }
                }
            }
        }
        /// <summary>
        /// 增加node
        /// </summary>
        /// <param name="pNode"></param>
        /// <param name="code">初始化tree时不为null；弹出菜单新增node时为null</param>
        private Node addNode(Node pNode, Tb_code code = null)
        {
            Node node = new Node();
            node.ContextMenu = cms;
            pNode.Nodes.Add(node);
            node.Editable = node.Level < 2 ? false : true;//level0是根节点，level1是分类，都不允许修改。level大于等于2时可以修改
            if (code == null)//弹出菜单上新增node
            {
                node.Style = new ElementStyle() { BackColor = Color.Red };
                node.BeginEdit();
            }
            else//初始化tree时新增node
            {
                node.Text = code.codeName;
                node.Tag = code;
            }
            return node;
        }
        private void editNode(Node node)
        {
            if (node.Style != null)//防止对新增node的red背景再变为green
            {
                node.Style = new ElementStyle() { BackColor = Color.LawnGreen };
            }
            node.BeginEdit();
        }
        private void btn_saveTree_Click(object sender, EventArgs e)
        {
            traversalNode(rootNode);
        }
        private void traversalNode(Node pNode)
        {
            if (pNode.HasChildNodes)
            {
                foreach (Node node in pNode.Nodes)
                {
                    if (node.Style != null)
                    {
                        if (node.Style.BackColor == Color.LawnGreen)//修改过的node
                        {
                            var tb_code = node.Tag as Tb_code;
                            tb_code.codeName = node.Text;
                            CodeCache.addCache(tb_code);
                            node.Style = null;
                        }
                        if (node.Style.BackColor == Color.Red)//新增的node
                        {
                            Tb_code tb_code = new Tb_code();
                            tb_code.codeName = node.Text;
                            if (node.Level == 2)//检测内容
                            {
                                tb_code.codeType = 6;
                                tb_code.id = CodeCache.getDetection().Count == 0 ? 6000 : CodeCache.getDetection().Max(c => c.id) + 1;//检测内容从6000开始
                            }
                            if (node.Level == 3)//检测分项
                            {
                                tb_code.codeType = 7;
                                tb_code.id = CodeCache.getSubDetection().Count == 0 ? 7000 : CodeCache.getSubDetection().Max(c => c.id) + 1;//检测分项从7000开始
                            }
                            tb_code.parentId = (node.Parent.Tag as Tb_code).id;
                            CodeCache.addCache(tb_code);
                            node.Style = null;
                            node.Tag = tb_code;//将code赋给tag，以便在新增node的新增子node中，可以找到parentId
                        }
                    }
                    traversalNode(node);
                }
            }
        }
        #endregion

        #region 指标模板tab
        /// <summary>
        /// 初始化IndicatorTemplateSelecter控件
        /// </summary>
        private void initIts()
        {
            its.indicatorList = indicatorList;
            its.classList = classList;
            its.detectionList = detectionList;
            its.subDetectionList = subDetectionList;
            its.init();
        }
        #endregion

    }
}
