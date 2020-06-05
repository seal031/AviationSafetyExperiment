using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    public class TaskResultAdapter:BaseAdapter
    {
        public static void saveResults(List<Tb_taskResult> taskResultList)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                context.Tb_taskResults.AddRange(taskResultList);
                context.SaveChanges();
            }
        }
    }
}
