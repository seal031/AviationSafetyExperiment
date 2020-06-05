using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviationSafetyExperiment.Db.DAO;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskQueryPanel : UserControl
    {
        public ITaskQueryEnable taskQuery;

        public TaskQueryPanel()
        {
            InitializeComponent();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            taskQuery.doQuery(new TaskQueryItem() { taskQueryName = txt_taskQueryName.Text.Trim(), taskQueryBrand = txt_taskQueryBrand.Text.Trim() });
        }
    }
}
