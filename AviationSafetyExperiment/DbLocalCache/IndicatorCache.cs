using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class IndicatorCache
    {
        private static List<Tb_indicator> list = new List<Tb_indicator>();

        static IndicatorCache()
        {
            getFromDb();
        }

        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_indicator>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_indicator> getCache()
        {
            return list;
        }

        public static void addCache(Tb_indicator indicator)
        {
            try
            {
                var foundIndicator = list.FirstOrDefault(i => i.id == indicator.id);
                if (foundIndicator == null)
                {
                    BaseAdapter.save(indicator);
                    list.Add(indicator);
                }
                else
                {
                    BaseAdapter.edit(indicator);
                    //IndicatorAdapter.edit(indicator);
                    foundIndicator = indicator;
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
