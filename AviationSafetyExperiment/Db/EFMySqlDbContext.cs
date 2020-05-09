using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db
{
    public class EFMySqlDbContext:DbContext
    {
        public EFMySqlDbContext() : base("name=EFMySqlDbContext")
        { }

        public virtual DbSet<Tb_code> Tb_codes { get; set; }
    }
}
