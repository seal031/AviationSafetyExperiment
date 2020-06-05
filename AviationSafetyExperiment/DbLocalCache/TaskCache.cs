using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using DevComponents.DotNetBar;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class TaskCache
    {
        private static List<Tb_taskInfo> list = new List<Tb_taskInfo>();

        static TaskCache()
        {
            getFromDb();
        }

        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_taskInfo>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_taskInfo> getCache()
        {
            return list;
        }

        public static List<Tb_taskInfo> getCacheByStateId(int stateId)
        {
            return list.Where(t => t.taskState == stateId).ToList();
        }

        public static Tb_taskInfo getCacheById(int id)
        {
            return list.FirstOrDefault(t => t.id == id);
        }

        /// <summary>
        /// 新增任务，及任务相关的表（任务指标映射表、任务型号映射表、任务生命周期表）
        /// </summary>
        /// <param name="task"></param>
        /// <param name="indicatorIdList"></param>
        public static void createTask(Tb_taskInfo task, List<int> indicatorIdList, Dictionary<int, List<int>> brandModelIdDic)
        {
            TaskAdapter.createTask(task, indicatorIdList, brandModelIdDic);
        }

        /// <summary>
        /// 保存一次任务处理结果
        /// </summary>
        /// <param name="task"></param>
        public static void saveTask(Tb_taskInfo task, List<Tb_taskResult> resultList)
        {
            TaskAdapter.saveTask(task,resultList);
        }

        /// <summary>
        /// 添加任务生命周期，同时更新任务信息中的任务最新状态
        /// </summary>
        /// <param name="taskLifecycle"></param>
        public static void updateTaskLifecycle(Tb_taskLifecycle taskLifecycle)
        {
            TaskAdapter.updateTaskLifecycle(taskLifecycle);
        }

        public static void addCache(Tb_taskInfo taskInfo)
        {
            try
            {
                var foundTaskInfo = list.FirstOrDefault(i => i.id == taskInfo.id);
                if (foundTaskInfo == null)
                {
                    BaseAdapter.save(taskInfo);
                    list.Add(taskInfo);
                }
                else
                {
                    BaseAdapter.edit(taskInfo);
                    //IndicatorAdapter.edit(indicator);
                    foundTaskInfo = taskInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        /// <summary>
        /// 更新任务状态及增加任务生命周期
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="stateId"></param>
        /// <param name="remark"></param>
        public static void updateTaskState(int taskId, int stateId, string remark = "")
        {
            var task = TaskCache.getCacheById(taskId);
            task.taskState = stateId;
            if (stateId == 5005)//如果任务已完成，将任务进度设置为100
            {
                task.percent = 100;
            }
            TaskCache.addCache(task);
            Tb_taskLifecycle life = new Tb_taskLifecycle()
            {
                taskId = taskId,
                taskStateDateTime = DateTime.Now,
                taskState = stateId,
                taskStateChangeExecutor = UserInfo.userName,
                remark = remark
            };
            TaskLifecycleCache.addCache(life);
        }
    }
}
