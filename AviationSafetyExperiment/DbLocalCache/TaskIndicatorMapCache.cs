using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.DbLocalCache
{
    public  class TaskIndicatorMapCache
    {
        private static List<Tb_taskIndicatorMap> list = new List<Tb_taskIndicatorMap>();

        static TaskIndicatorMapCache()
        {
            getFromDb();
        }

        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_taskIndicatorMap>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_taskIndicatorMap> getCache()
        {
            return list;
        }

        public static void addCacheOnly(Tb_taskIndicatorMap taskIndicatorMap)
        {
            try
            {
                var temp = list.FirstOrDefault(tim => tim.id == taskIndicatorMap.id);
                if (temp == null)
                {
                    list.Add(taskIndicatorMap);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("缓存任务过程时出现异常:" + ex);
            }
        }
    }
}
