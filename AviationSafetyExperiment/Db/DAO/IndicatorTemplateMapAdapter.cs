using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.DAO
{
    public class IndicatorTemplateMapAdapter:BaseAdapter
    {
        public static void updateMap(int templateId, List<int> indicatorIdList)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var listToDel = context.Tb_indicatorTemplateMaps.Where(itm => itm.templateId == templateId);
                        context.Tb_indicatorTemplateMaps.RemoveRange(listToDel);
                        foreach (int indicatorId in indicatorIdList)
                        {
                            context.Tb_indicatorTemplateMaps.Add(new Entity.Tb_indicatorTemplateMap() { templateId = templateId, indicatorId = indicatorId });
                        }
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
