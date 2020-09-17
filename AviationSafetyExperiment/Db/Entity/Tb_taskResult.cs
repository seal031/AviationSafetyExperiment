using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public class Tb_taskResult:BaseEntity
    {
        /// <summary>
        /// 测试id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// 测试步次
        /// </summary>
        public int taskStep { get; set; }
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
        /// 型号id
        /// </summary>
        public int modelId { get; set; }
        /// <summary>
        /// 指标项id
        /// </summary>
        public int indicatorId { get; set; }
        /// <summary>
        /// 测试记录
        /// </summary>
        [MaxLength(300)]
        public string taskRecord { get; set; }
        /// <summary>
        /// 测试结论
        /// </summary>
        public int taskResult { get; set; }
        /// <summary>
        /// 测试备注
        /// </summary>
        [MaxLength(300)]
        public string taskRemark { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        [MaxLength(100)]
        public string attachment { get; set; }
        /// <summary>
        /// 补充内容
        /// </summary>
        [MaxLength(500)]
        public string supplement { get; set; }
        /// <summary>
        /// 测试轮次
        /// </summary>
        public int taskRound { get; set; }
    }
}
