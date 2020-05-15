using AviationSafetyExperiment.Db.DAO;
using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.DbLocalCache
{
    public class CodeCache
    {
        private static List<Tb_code> list = new List<Tb_code>();

        static CodeCache()
        {
            getFromDb();
        }


        public static void getFromDb()
        {
            var tempList = BaseAdapter.getAll<Tb_code>();
            if (tempList.Count() > 0)
            {
                list.Clear();
                list = tempList.ToList();
            }
        }

        public static List<Tb_code> getCache()
        {
            return list;
        }

        public static void addCache(Tb_code code)
        {
            var foundCode = list.FirstOrDefault(c => c.id == code.id);
            if (foundCode == null)
            {
                BaseAdapter.save(code);
                list.Add(code);
            }
            else
            {
                BaseAdapter.edit(code);
                foundCode = code;
            }
        }

        public static List<Tb_code> getClass()
        {
            return list.Where(c => c.codeType == (int)(CodeTypeEnum.Class)).ToList();
        }
        public static List<Tb_code> getBrand()
        {
            return list.Where(c => c.codeType == (int)(CodeTypeEnum.Brand)).ToList();
        }
        public static List<Tb_code> getModel()
        {
            return list.Where(c => c.codeType == (int)(CodeTypeEnum.Model)).ToList();
        }

        public static List<Tb_code> getDetection()
        {
            return list.Where(c => c.codeType == (int)(CodeTypeEnum.Detection)).ToList();
        }
        public static List<Tb_code> getSubDetection()
        {
            return list.Where(c => c.codeType == (int)(CodeTypeEnum.SubDetection)).ToList();
        }
    }
}
