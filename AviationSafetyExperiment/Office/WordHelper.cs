using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Office
{
    public class WordHelper
    {
        public static void CreateFileByTemplate(string tempFile, string saveFile)
        {
            using (FileStream stream = File.OpenRead(tempFile))
            {
                XWPFDocument doc = new XWPFDocument(stream);

                //遍历段落                 
                foreach (var para in doc.Paragraphs)
                {
                    
                }

                //遍历表格     
                foreach (var table in doc.Tables)
                {
                    foreach (var row in table.Rows)
                    {
                        foreach (var cell in row.GetTableCells())
                        {
                            foreach (var para in cell.Paragraphs)
                            {
                                
                            }
                        }
                    }
                }
                FileStream out1 = new FileStream(saveFile, FileMode.Create);
                doc.Write(out1);
                out1.Close();
            }
        }
    }
}
