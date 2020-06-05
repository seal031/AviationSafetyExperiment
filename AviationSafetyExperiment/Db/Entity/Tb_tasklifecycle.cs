using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 测试生命周期
    /// </summary>
    public class Tb_taskLifecycle:BaseEntity
    {
        /// <summary>
        /// 测试id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// 测试状态
        /// </summary>
        public int taskState { get; set; }
        /// <summary>
        /// 状态时间
        /// </summary>
        public DateTime taskStateDateTime { get; set; }
        /// <summary>
        /// 状态变更执行人
        /// </summary>
        [MaxLength(30)]
        public string taskStateChangeExecutor { get; set; }
        /// <summary>
        /// 状态备注（如驳回原因等）
        /// </summary>
        [MaxLength(100)]
        public string remark { get; set; }
    }
}
