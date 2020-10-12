using AviationSafetyExperiment.Db;
using AviationSafetyExperiment.Office;
using AviationSafetyExperiment.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //WordHelper.CreateFileByTemplate("ReportTemplate\\ReportTemplate.docx", "ReportStore\\1.docx");
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFMySqlDbContext>());
            Database.SetInitializer<EFMySqlDbContext>(null);
            using (var context = new EFMySqlDbContext())
            {
                //context.Tb_codes.Add(new Db.Entity.Tb_code() { codeName = "1", codeType = 1 });
                //context.SaveChanges();
                //var code = context.Tb_codes.FirstOrDefault(c => c.code_id == 1);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new ChartForm());
        }
    }

}
