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
    /// <summary>
    /// 用于显示任务基本信息组件
    /// </summary>
    public partial class TaskDetialBaseInfoPanel : UserControl
    {
        private Tb_taskInfo taskInfo;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        var parms = base.CreateParams;
        //        parms.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN 
        //        return parms;
        //    }
        //}
        public TaskDetialBaseInfoPanel()
        {
            InitializeComponent();
        }

        public void init(int taskId)
        {
            taskInfo = TaskCache.getCacheById(taskId);
            if (taskInfo == null)
            {
                MessageBoxEx.Show("未能查询到测试任务");
            }
            else
            {
                bindTaskInfo();
            }
        }

        private void bindTaskInfo()
        {
            lbl_taskName.Text = taskInfo.taskName;
            lbl_taskExecutor.Text = taskInfo.taskExecutor;
            lbl_taskClass.Text = CodeCache.getClass().FirstOrDefault(c => c.id == taskInfo.taskClass).codeName;
            lbl_taskCode.Text = taskInfo.taskCode;
            lbl_taskType.Text = CodeCache.getType().FirstOrDefault(c => c.id == taskInfo.taskType).codeName;
            lbl_brandModel.Text = string.Join(Environment.NewLine, from brandCode in CodeCache.getBrand()
                                                                   from modelCode in CodeCache.getModel()
                                                                   from taskModelMap in TaskModelMapCache.getCache()
                                                                   where taskModelMap.taskId == taskInfo.id && taskModelMap.brandId == brandCode.id && taskModelMap.ModelId == modelCode.id
                                                                   select brandCode.codeName + "    " + modelCode.codeName);
        }
    }
}
