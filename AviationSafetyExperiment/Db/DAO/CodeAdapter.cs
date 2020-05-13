using AviationSafetyExperiment.Db;
using AviationSafetyExperiment.Db.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AviationSafetyExperiment.DAO
{
    internal class CodeAdapter
    {
        public static IList<Tb_code> getAll()
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Tb_codes.ToList();
            }
        }

        public static Tb_code getById(int id)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                return context.Tb_codes.FirstOrDefault(i => i.codeId == id);
            }
        }

        public static void save(Tb_code code)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    context.Tb_codes.Add(code);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("保存失败：" + ex.Message);
                }
            }
        }

        public static void edit(Tb_code code)
        {
            using (EFMySqlDbContext context = new Db.EFMySqlDbContext())
            {
                try
                {
                    var foundCode= context.Tb_codes.FirstOrDefault(i => i.codeId == code.codeId);
                    if (foundCode != null)
                    {
                        foundCode.codeId = code.codeId;
                        foundCode.codeName = code.codeName;
                        foundCode.codeType = code.codeType;
                        foundCode.parentId = code.parentId;
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("修改失败：" + ex.Message);
                }
            }
        }
    }
}