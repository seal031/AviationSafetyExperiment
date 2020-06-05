using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
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
    }
}
