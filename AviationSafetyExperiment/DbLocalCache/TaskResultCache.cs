using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class TaskResultCache
    {
        private static List<Tb_taskResult> list = new List<Tb_taskResult>();

        static TaskResultCache()
        {
            getFromDb();
        }

        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_taskResult>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_taskResult> getCache()
        {
            return list;
        }

        public static void addCache(List<Tb_taskResult> taskResultList)
        {
            try
            {
                TaskResultAdapter.saveResults(taskResultList);
                list.AddRange(taskResultList);//更新到本地缓存
            }
            catch (Exception)
            {
                
            }
        }
    }
}
