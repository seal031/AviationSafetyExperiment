using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 指标表
    /// </summary>
    public class Tb_indicator:BaseEntity
    {
        /// <summary>
        /// 分类id（摄像机、门禁、围界……）
        /// </summary>
        public int classId { get; set; }
        /// <summary>
        /// 指标所属检测内容
        /// </summary>
        public int detectionId { get; set; }
        /// <summary>
        /// 指标所属检测分项
        /// </summary>
        public int subDetectionId { get; set; }
        /// <summary>
        /// 指标名称
        /// </summary>
        [MaxLength(200)]
        public string indicatorName { get; set; }
        /// <summary>
        /// 指标描述
        /// </summary>
        [MaxLength(10000)]
        public string indicatorDesc { get; set; }
        /// <summary>
        /// 操作说明
        /// </summary>
        [MaxLength(10000)]
        public string indicatorInstr { get; set; }
        /// <summary>
        /// 是否废弃的指标
        /// </summary>
        public int isObsolete { get; set; }
    }
}
