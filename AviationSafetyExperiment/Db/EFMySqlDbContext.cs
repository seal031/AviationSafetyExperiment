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

        public virtual DbSet<Tb_indicator> Tb_indicators { get; set; }

        public virtual DbSet<Tb_taskInfo> Tb_taskInfos { get; set; }

        public virtual DbSet<Tb_taskLifecycle> Tb_taskLifecycles { get; set; }

        public virtual DbSet<Tb_taskProcess> Tb_taskProcesses { get; set; }

        public virtual DbSet<Tb_taskResult> Tb_taskResults { get; set; }

        public virtual DbSet<Tb_taskModelMap> Tb_taskModelMaps { get; set; }

        public virtual DbSet<Tb_taskIndicatorMap> Tb_taskIndicatorMaps { get; set; }

        public DbSet<T> getDbSet<T>() where T : class
        {
            if (typeof(T)==typeof(Tb_code))
            {
                return Tb_codes as DbSet<T>;
            }
            if (typeof(T) == typeof(Tb_indicator))
            {
                return Tb_indicators as DbSet<T>;
            }
            else
            {
                return null;
            }
        }
    }
}
