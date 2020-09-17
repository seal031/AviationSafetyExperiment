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
using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.DbLocalCache;

namespace AviationSafetyExperiment.UserControls
{
    public partial class TaskQueryPanel : UserControl
    {
        public List<ITaskQueryEnable> taskQueryList=new List<ITaskQueryEnable>();
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskQueryPanel()
        {
            InitializeComponent();
            var taskStateList = CodeCache.getState();
            cbb_taskState.DisplayMember = "codeName";
            cbb_taskState.ValueMember = "id";
            cbb_taskState.DataSource = taskStateList;
            cbb_taskState.SelectedItem = null;
        }

        public void setTaskQuery(ITaskQueryEnable taskQuery)
        {
            if (taskQueryList.Contains(taskQuery) == false)
            {
                taskQueryList.Add(taskQuery);
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            foreach (var taskQuery in taskQueryList)
            {
                taskQuery.doQuery(new TaskQueryItem()
                {
                    taskQueryName = txt_taskQueryName.Text.Trim(),
                    taskQueryBrand = txt_taskQueryBrand.Text.Trim(),
                    taskState = cbb_taskState.SelectedItem == null ? 0 : (cbb_taskState.SelectedItem as Tb_code).id
                }
                );
            }
        }
    }


    public interface IPagging
    {
        void doPagging(int pageNum,int pageSize);
    }
}
