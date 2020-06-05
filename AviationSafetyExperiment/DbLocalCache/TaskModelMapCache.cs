using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class TaskModelMapCache
    {
        private static List<Tb_taskModelMap> list = new List<Tb_taskModelMap>();

        static TaskModelMapCache()
        {
            getFromDb();
        }

        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_taskModelMap>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_taskModelMap> getCache()
        {
            return list;
        }

    }
}
