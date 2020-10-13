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
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        for (int i = 0; i < taskResultList.Count; i++)
                        {

                            context.Tb_taskResults.Add(taskResultList[i]);
                            context.SaveChanges();
                            context.Entry(taskResultList[i]);
                            int resultId = taskResultList[i].id;
                            string supple = taskResultList[i].supplement;
                            ResultSupplement resultSupp = ResultSupplement.fromJson(supple);
                            if (resultSupp != null)
                            {
                                foreach (var item in resultSupp.alarmInputList)
                                {
                                    Tb_alarminput alarm = new Tb_alarminput();
                                    alarm.taskId = taskResultList[i].taskId;
                                    alarm.resultId = resultId;
                                    alarm.alarmType = item.alarmType;
                                    alarm.alarmForm = item.alarmForm;
                                    alarm.classify = item.classify;
                                    alarm.describe = item.describe;
                                    context.Tb_alarminputs.Add(alarm);
                                    context.SaveChanges();
                                }
                            }
                            //context.Tb_alarminputs.Add()
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
                //context.Tb_taskResults.AddRange(taskResultList);
                //context.SaveChanges();
            }
        }
    }
}
