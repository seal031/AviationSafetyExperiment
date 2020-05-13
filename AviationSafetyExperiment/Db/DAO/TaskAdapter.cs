using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    public class TaskAdapter
    {
        public static IList<Tb_taskInfo> getAll()
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Tb_taskInfos.ToList();
            }
        }

        public static Tb_taskInfo getById(int id)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Tb_taskInfos.FirstOrDefault(i => i.taskId == id);
            }
        }

        public static void save(Tb_taskInfo taskInfo)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    context.Tb_taskInfos.Add(taskInfo);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("保存失败：" + ex.Message);
                }
            }
        }

        public static void edit(Tb_taskInfo taskInfo)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    var foundTaskInfo = context.Tb_taskInfos.FirstOrDefault(i => i.taskId == taskInfo.taskId);
                    if (foundTaskInfo != null)
                    {
                        foundTaskInfo.percent = taskInfo.percent;
                        foundTaskInfo.taskClass = taskInfo.taskClass;
                        foundTaskInfo.taskCode = taskInfo.taskCode;
                        foundTaskInfo.taskExecutor = taskInfo.taskExecutor;
                        foundTaskInfo.taskId = taskInfo.taskId;
                        foundTaskInfo.taskName = taskInfo.taskName;
                        foundTaskInfo.taskState = taskInfo.taskState;
                        foundTaskInfo.taskType = taskInfo.taskType;
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("修改失败：" + ex.Message);
                }
            }
        }
    }
}
