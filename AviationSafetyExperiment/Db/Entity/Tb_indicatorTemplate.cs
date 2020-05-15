using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public class Tb_indicatorTemplate:BaseEntity
    {
        /// <summary>
        /// 模板名称
        /// </summary>
        [MaxLength(30)]
        public string templateName { get; set; }
        /// <summary>
        /// 所属分类id
        /// </summary>
        public int classId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createDatetime { get; set; }
    }
}
