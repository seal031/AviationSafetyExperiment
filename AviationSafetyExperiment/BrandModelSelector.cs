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
    public partial class BrandModelSelector : DevComponents.DotNetBar.Office2007Form
    {
        public int classId;
        public Dictionary<int, List<int>> selectedDic = new Dictionary<int, List<int>>();

        public BrandModelSelector()
        {
            InitializeComponent();
        }

        public void initTree()
        {
            var brands = CodeCache.getBrand().Where(c => c.parentId == classId);
            foreach (var brand in brands)
            {
                DevComponents.AdvTree.Node node = new DevComponents.AdvTree.Node();
                node.Text = brand.id.ToString();
                CheckBoxItem cbi = new CheckBoxItem() {  Text = brand.codeName};
                cbi.CheckedChanged += Cbi_CheckedChanged;
                if (selectedDic.ContainsKey(brand.id)) { cbi.Checked = true; }
                node.HostedItem = cbi;
                var models = CodeCache.getModel().Where(c => c.parentId == brand.id);
                if (models.Count() == 0)
                {
                    cbi.Enabled = false;
                }
                tree.Nodes.Add(node);
                foreach(var model in models)
                {
                    DevComponents.AdvTree.Node subNode = new DevComponents.AdvTree.Node();
                    subNode.Text = model.id.ToString();
                    CheckBoxItem subCbi = new CheckBoxItem() { Text = model.codeName };
                    if (selectedDic.ContainsKey(brand.id))
                    {
                        if (selectedDic[brand.id].Contains(model.id))
                        {
                            subCbi.Checked = true;
                        }
                    }
                    subNode.HostedItem = subCbi;
                    node.Nodes.Add(subNode);
                }
            }
        }

        private void Cbi_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            var cbi = sender as CheckBoxItem;
            bool isChecked = cbi.Checked;
            foreach (DevComponents.AdvTree.Node node in tree.Nodes)
            {
                if (node.HostedItem == cbi)
                {
                    foreach (DevComponents.AdvTree.Node subNode in node.Nodes)
                    {
                        ((CheckBoxItem)subNode.HostedItem).Checked = isChecked;
                    }
                    break;
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            selectedDic.Clear();
            foreach (DevComponents.AdvTree.Node node in tree.Nodes)
            {
                int brandId = int.Parse(node.Text);
                List<int> modelIdList = new List<int>();
                foreach (DevComponents.AdvTree.Node subNode in node.Nodes)
                {
                    if (((CheckBoxItem)subNode.HostedItem).Checked)
                    {
                        modelIdList.Add(int.Parse(subNode.Text));
                    }
                }
                if (modelIdList.Count > 0)
                {
                    selectedDic.Add(brandId, modelIdList);
                }
            }
            this.Close();
        }
    }
}
