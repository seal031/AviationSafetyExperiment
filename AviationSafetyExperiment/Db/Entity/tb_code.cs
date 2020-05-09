using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    [Table("tb_code")]
    public class Tb_code
    {
        [Key,Column("code_id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int code_id { get; set; }

        public int code_type { get; set; }

        [MaxLength(30)]
        public string code_name { get; set; }
    }
}
