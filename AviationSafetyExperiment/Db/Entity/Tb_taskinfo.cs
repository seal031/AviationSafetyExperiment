using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 测试任务信息表
    /// </summary>
    [Table("tb_taskinfo")]
    public class Tb_taskInfo:BaseEntity
    {
        /// <summary>
        /// 测试名称
        /// </summary>
        [MaxLength(30)]
        public string taskName { get; set; }
        /// <summary>
        /// 测试人员
        /// </summary>
        [MaxLength(30)]
        public string taskExecutor { get; set; }
        /// <summary>
        /// 测试编码
        /// </summary>
        [MaxLength(30)]
        public string taskCode { get; set; }
        /// <summary>
        /// 测试类型
        /// </summary>
        public int taskType { get; set; }
        /// <summary>
        /// 测试种类(单品牌、多品牌)
        /// </summary>
        public int taskClass { get; set; }
        /// <summary>
        /// 测试最新状态
        /// </summary>
        public int taskState { get; set; }
        /// <summary>
        /// 测试进度百分比
        /// </summary>
        public int percent { get; set; }
    }
}
