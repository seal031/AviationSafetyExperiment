using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    /// <summary>
    /// 用于统计图表的查询
    /// </summary>
    public class CountChartAdapter
    {
        /// <summary>
        /// 查询每个月的任务数量
        /// </summary>
        /// <returns></returns>
        public static List<queryDateResult> selectEveryMonthTaskNum()
        {
            string sql = @"SELECT count(1) as number, dateNum
FROM
(
SELECT taskId,DATE_FORMAT(taskStateDateTime,'%Y.%m') dateNum
from tb_tasklifecycle
WHERE taskState in(5004,5005)
and TIMESTAMPDIFF(MONTH,NOW(),taskStateDateTime)<=6
group by taskId

) temp
GROUP BY dateNum
ORDER BY dateNum ";
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Database.SqlQuery<queryDateResult>(sql).ToList();
            }
        }
        public static List<queryClassifyResult> selectClassifyNum()
        {
            string sql = @"SELECT COUNT(1) as number,taskClass
FROM tb_taskinfo
WHERE taskState in(5004,5005)
GROUP BY taskClass";
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Database.SqlQuery<queryClassifyResult>(sql).ToList();
            }
        }

        public static List<queryEveryPersonTaskNum> selectEveryPersonTaskNum(string startTime,string endTime)
        {
            string sql = string.Format(@"SELECT * FROM
(
select taskExecutor,DATE_FORMAT(taskDateTime,'%Y.%m') as dateNum,count(1)as number
from tb_taskresult temp
where taskStep=(SELECT max(taskStep) from tb_taskresult where taskId=temp.taskId and taskExecutor=temp.taskExecutor and taskRound=temp.taskRound)
and taskDateTime BETWEEN '{0}' AND '{1}'
GROUP BY taskExecutor,dateNum
ORDER BY taskExecutor
) tb
ORDER BY dateNum", startTime,endTime);
            using (EFMySqlDbContext context = new EFMySqlDbContext())
            {
                return context.Database.SqlQuery<queryEveryPersonTaskNum>(sql).ToList();
            }
        }
    }
    public class queryDateResult
    {
        public int number { get; set; }
        public string dateNum { get; set; }
    }
    public class queryClassifyResult
    {
        public int number { get; set; }
        public string taskClass { get; set; }
    }
    public class queryEveryPersonTaskNum
    {
        public string taskExecutor { get; set; }//姓名
        public string dateNum { get; set; }//日期
        public int number { get; set; }//统计结果
    }
}
