using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    /// <summary>
    /// 任务查询辅助类
    /// </summary>
    public class TaskQueryHelper
    {


    }

    public interface ITaskQueryEnable
    {
        void doQuery(TaskQueryItem queryItem);
    }

    public class TaskQueryItem
    {
        public string taskQueryName { get; set; } = string.Empty;

        public string taskQueryBrand { get; set; } = string.Empty;

        public int taskState { get; set; } = 0;
    }
}
