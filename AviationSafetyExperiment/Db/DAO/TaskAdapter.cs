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
        /// <summary>
        /// 新增任务，及任务相关的表（任务指标映射表、任务生命周期表）
        /// </summary>
        /// <param name="task"></param>
        /// <param name="indicatorIdList"></param>
        public static void createTask(Tb_taskInfo task, List<int> indicatorIdList,Dictionary<int,List<int>> brandModelIdDic)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        //新增任务信息
                        context.Tb_taskInfos.Add(task);
                        context.SaveChanges();
                        context.Entry(task);
                        int taskId = task.id;
                        //添加任务生命周期
                        Tb_taskLifecycle lifecycle = new Tb_taskLifecycle();
                        lifecycle.taskId = taskId;
                        lifecycle.taskStateDateTime = DateTime.Now;
                        lifecycle.taskStateChangeExecutor = task.taskExecutor;
                        lifecycle.taskState = 5001;
                        lifecycle.remark = string.Empty;
                        context.Tb_taskLifecycles.Add(lifecycle);
                        context.SaveChanges();
                        //添加任务型号映射
                        List<Tb_taskModelMap> tmmList = new List<Entity.Tb_taskModelMap>();
                        foreach (int brandId in brandModelIdDic.Keys)
                        {
                            foreach (int modelId in brandModelIdDic[brandId])
                            {
                                Tb_taskModelMap tmm = new Tb_taskModelMap();
                                tmm.taskId = taskId;
                                tmm.brandId = brandId;
                                tmm.ModelId = modelId;
                                tmmList.Add(tmm);
                            }
                        }
                        context.Tb_taskModelMaps.AddRange(tmmList);
                        context.SaveChanges();
                        //添加任务指标映射
                        List<Tb_taskIndicatorMap> timList = new List<Tb_taskIndicatorMap>();
                        foreach (int indicatorId in indicatorIdList)
                        {
                            Tb_taskIndicatorMap tim = new Tb_taskIndicatorMap();
                            tim.taskId = taskId;
                            tim.indicatorId = indicatorId;
                            timList.Add(tim);
                        }
                        context.Tb_taskIndicatorMaps.AddRange(timList);
                        context.SaveChanges();
                        //提交数据库
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        /// <summary>
        /// 保存一次任务处理结果
        /// </summary>
        /// <param name="task"></param>
        public static void saveTask(Tb_taskInfo task,List<Tb_taskResult> resultList)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var currentTask = context.Tb_taskInfos.FirstOrDefault(t => t.id == task.id);
                        if (currentTask == null) { return; }
                        else
                        {
                            currentTask = task;
                            context.SaveChanges();
                            //增加任务进度
                            context.Tb_taskResults.AddRange(resultList);
                            context.SaveChanges();
                            //提交数据库
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
        /// <summary>
        /// 添加任务生命周期，同时更新任务信息中的任务最新状态
        /// </summary>
        /// <param name="taskLifecycle"></param>
        public static void updateTaskLifecycle(Tb_taskLifecycle taskLifecycle)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var task = context.Tb_taskInfos.FirstOrDefault(t => t.id == taskLifecycle.taskId);
                        if (task == null)
                        {
                            return;
                        }
                        else
                        {
                            //添加生命周期
                            context.Tb_taskLifecycles.Add(taskLifecycle);
                            context.SaveChanges();
                            //修改任务最新状态
                            task.taskState = taskLifecycle.taskState;
                            context.SaveChanges();
                            //提交数据库
                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        /// <summary>
        /// 完成任务
        /// </summary>
        /// <param name="task"></param>
        public static void completeTask(Tb_taskInfo task)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
