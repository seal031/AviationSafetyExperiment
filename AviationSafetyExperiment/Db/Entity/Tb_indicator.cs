using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 指标表
    /// </summary>
    public class Tb_indicator
    {
        [Key]
        /// <summary>
        /// 指标项id
        /// </summary>
        public int indicatorId { get; set; }
        /// <summary>
        /// 分类id（摄像机、门禁、围界……）
        /// </summary>
        public int classId { get; set; }
        /// <summary>
        /// 指标名称
        /// </summary>
        [MaxLength(30)]
        public string indicatorName { get; set; }
        /// <summary>
        /// 指标描述
        /// </summary>
        [MaxLength(300)]
        public string indicatorDesc { get; set; }
        /// <summary>
        /// 是否废弃的指标
        /// </summary>
        public int isObsolete { get; set; }
    }
}
