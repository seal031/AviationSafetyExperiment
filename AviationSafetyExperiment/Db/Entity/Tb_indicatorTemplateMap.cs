using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public class Tb_indicatorTemplateMap : BaseEntity
    {
        public int templateId { get; set; }

        public int indicatorId { get; set; }
    }
}
