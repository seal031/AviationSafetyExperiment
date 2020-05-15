using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    public class BaseAdapter
    {
        public static IList<T> getAll<T>() where T : BaseEntity
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.getDbSet<T>().ToList();
            }
        }

        public static T getById<T>(int id) where T : BaseEntity
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.getDbSet<T>().FirstOrDefault(i => i.id == id);
            }
        }

        public static void save<T>(T t) where T : BaseEntity
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    context.getDbSet<T>().Add(t);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("保存失败：" + ex.Message);
                }
            }
        }

        public static void edit<T>(T entity) where T : BaseEntity
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    var foundIndicator = context.getDbSet<T>().FirstOrDefault(i => i.id == entity.id);
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
