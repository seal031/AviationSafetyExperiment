using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment
{
    /// <summary>
    /// MainForm代理类，持有mainForm对象，供其他组件调用mainForm中的方法
    /// </summary>
    public class MainFormAdapter
    {
        private static MainForm mainForm;

        public static void setMainForm(MainForm _mainForm)
        {
            mainForm = _mainForm;
        }

        /// <summary>
        /// 重新加载mainform中的4个列表（待处理、处理中、已处理、测试报告）
        /// </summary>
        public static void reloadTaskMainPanel()
        {
            mainForm.reloadTaskMainPanel();
        }
        /// <summary>
        /// 重新加载mainform中的任务审批列表
        /// </summary>
        public static void reloadTaskApproval()
        {
            mainForm.reloadTaskApproval();
        }
    }
}
