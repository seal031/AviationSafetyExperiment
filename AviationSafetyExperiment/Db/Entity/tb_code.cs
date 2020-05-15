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
    /// 代码表
    /// </summary>
    [Table("tb_code")]
    public class Tb_code:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override int id { get; set; }
        /// <summary>
        /// 代码类型
        /// </summary>
        public int codeType { get; set; }
        /// <summary>
        /// 父代码id（可空）
        /// </summary>
        public int? parentId { get; set; }
        /// <summary>
        /// 代码名称
        /// </summary>
        [MaxLength(30)]
        public string codeName { get; set; }
    }
}
