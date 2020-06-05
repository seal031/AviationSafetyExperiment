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
    public class TaskLifecycleCache
    {
        private static List<Tb_taskLifecycle> list = new List<Tb_taskLifecycle>();

        static TaskLifecycleCache()
        {
            getFromDb();
        }

        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_taskLifecycle>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_taskLifecycle> getCache()
        {
            return list;
        }

        public static void addCache(Tb_taskLifecycle life)
        {
            try
            {
                BaseAdapter.save(life);
                list.Add(life);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("保存任务过程时出现异常:"+ex);
            }
        }
    }
}
