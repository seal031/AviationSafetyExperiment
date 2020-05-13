using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    public class IndicatorAdapter
    {
        public static IList<Tb_indicator> getAll()
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Tb_indicators.ToList();
            }
        }

        public static Tb_indicator getById(int id)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Tb_indicators.FirstOrDefault(i => i.indicatorId == id);
            }
        }

        public static void save(Tb_indicator indicator)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    context.Tb_indicators.Add(indicator);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("保存失败：" + ex.Message);
                }
            }
        }

        public static void edit(Tb_indicator indicator)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    var foundIndicator = context.Tb_indicators.FirstOrDefault(i => i.indicatorId == indicator.indicatorId);
                    if (foundIndicator != null)
                    {
                        foundIndicator.classId = indicator.classId;
                        foundIndicator.indicatorDesc = indicator.indicatorDesc;
                        foundIndicator.indicatorId = indicator.indicatorId;
                        foundIndicator.indicatorName = indicator.indicatorName;
                        foundIndicator.isObsolete = indicator.isObsolete;
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("修改失败：" + ex.Message);
                }
            }
        }

        public static void edit<T>(T entity) where T : Tb_indicator
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    var foundIndicator = context.getDbSet<T>().FirstOrDefault(i => i.indicatorId == entity.indicatorId);
                    PropertyInfo[] properties = typeof(T).GetProperties();
                    foreach (var property in properties)
                    {
                        string text = property.Name;
                        property.SetValue(foundIndicator, property.GetValue(entity));
                    }
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("修改失败：" + ex.Message);
                }
            }
        }
    }
}
