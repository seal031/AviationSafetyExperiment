using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public class Tb_taskResult
    {
        [Key]
        /// <summary>
        /// 测试结果id
        /// </summary>
        public int taskResultId { get; set; }
        /// <summary>
        /// 测试过程id
        /// </summary>
        public int taskProcessId { get; set; }
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
    }
}
