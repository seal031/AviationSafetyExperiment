using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 测试与指标映射表（多对多关系）
    /// </summary>
    public class Tb_taskIndicatorMap:BaseEntity
    {
        /// <summary>
        /// 测试任务id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// 指标项id
        /// </summary>
        public int indicatorId { get; set; }
    }
}
