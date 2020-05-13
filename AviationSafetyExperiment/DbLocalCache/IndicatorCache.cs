using AviationSafetyExperiment.Db;
using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var tempList = IndicatorAdapter.getAll();
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
                var foundIndicator = list.FirstOrDefault(i => i.indicatorId == indicator.indicatorId);
                if (foundIndicator == null)
                {
                    IndicatorAdapter.save(indicator);
                    list.Add(indicator);
                }
                else
                {
                    IndicatorAdapter.edit<Tb_indicator>(indicator);
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
