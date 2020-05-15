using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class IndicatorTemplateMapCache
    {
        private static List<Tb_indicatorTemplateMap> list = new List<Tb_indicatorTemplateMap>();

        static IndicatorTemplateMapCache()
        {
            getFromDb();
        }


        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_indicatorTemplateMap>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_indicatorTemplateMap> getCache()
        {
            return list;
        }

        public static void addCache(Tb_indicatorTemplateMap templateMap)
        {
            var foundTemplate = list.FirstOrDefault(c => c.id == templateMap.id);
            if (foundTemplate == null)
            {
                BaseAdapter.save(templateMap);
                list.Add(templateMap);
            }
            else
            {
                BaseAdapter.edit(templateMap);
                foundTemplate = templateMap;
            }
        }
    }
}
