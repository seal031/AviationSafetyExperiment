using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 测试与型号映射表（多对多关系）
    /// </summary>
    public class Tb_taskModelMap
    {
        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public int tmMapId { get; set;}
        /// <summary>
        /// 测试任务id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// 品牌id
        /// </summary>
        public int brandId { get; set; }
        /// <summary>
        /// 型号id
        /// </summary>
        public int ModelId { get; set; }
    }
}
