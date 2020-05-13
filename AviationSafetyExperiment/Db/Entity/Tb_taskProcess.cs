using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 测试过程经历
    /// </summary>
    public class Tb_taskProcess
    {
        [Key]
        /// <summary>
        /// 测试过程id
        /// </summary>
        public int taskProcessId { get; set; }
        /// <summary>
        /// 测试id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// 测试轮次
        /// </summary>
        public int taskRound { get; set; }
        /// <summary>
        /// 测试执行者
        /// </summary>
        [MaxLength(30)]
        public string taskExecutor { get; set; }
        /// <summary>
        /// 测试时间
        /// </summary>
        public DateTime taskDateTime { get; set; }
        /// <summary>
        /// 是否最后一次测试
        /// </summary>
        public int isEnd { get; set; }
    }
}
