using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class TemplateCache
    {
        private static List<Tb_indicatorTemplate> list = new List<Tb_indicatorTemplate>();

        static TemplateCache()
        {
            getFromDb();
        }


        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_indicatorTemplate>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_indicatorTemplate> getCache()
        {
            return list;
        }

        public static void addCache(Tb_indicatorTemplate template)
        {
            var foundTemplate = list.FirstOrDefault(c => c.id == template.id);
            if (foundTemplate == null)
            {
                BaseAdapter.save(template);
                list.Add(template);
            }
            else
            {
                BaseAdapter.edit(template);
                foundTemplate = template;
            }
        }
    }
}
