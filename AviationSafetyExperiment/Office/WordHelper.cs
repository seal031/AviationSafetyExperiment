using AviationSafetyExperiment.Model;
using AviationSafetyExperiment.Utils;
using MySql.Data.MySqlClient.Properties;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment.Office
{
    public class WordHelper
    {
        public static void CreateFileByTemplate(List<TaskResultModel> resultList, string tempFile, string saveFile,string taskId)
        {
            using (FileStream stream = File.OpenRead(tempFile))
            {
                XWPFDocument doc = new XWPFDocument(stream);
                //遍历段落                 
                foreach (var para in doc.Paragraphs)
                {

                }
                //遍历表格 
                List<string> picFormat = new List<string>();
                picFormat.Add(".jpeg");
                picFormat.Add(".jpg");
                picFormat.Add(".png");
                picFormat.Add(".bmp");
                picFormat.Add(".tiff");
                picFormat.Add(".svg");
                picFormat.Add(".gif");
                //picFormat.Add("");
                for (int index = 0; index < doc.Tables.Count; index++)
                {
                    XWPFTable table = doc.Tables[index];
                    if (index == 2)
                    {
                        int num = table.Rows.Count - 3 - resultList.Count;//总行数-文字描述的行数-测试项目的数量 = 要删除,或者增加的单元格行数
                        if (num >= 0)
                        {
                            for (int i = 0; i < num; i++)
                            {
                                table.RemoveRow(2 + resultList.Count);
                            }
                        }
                        else//如何测试项目大于当前文档已有的行数,需要进行添加行的操作
                        {
                            for (int i = num; i < 0; i++)
                            {
                                NPOI.OpenXmlFormats.Wordprocessing.CT_Row nr = new NPOI.OpenXmlFormats.Wordprocessing.CT_Row();
                                XWPFTableRow mr = new XWPFTableRow(nr, table);//创建行 
                                //mr.AddNewTableCell();
                                //mr.AddNewTableCell();
                                //mr.AddNewTableCell();
                                //mr.AddNewTableCell();
                                //mr.AddNewTableCell();
                                //mr.AddNewTableCell();
                                mr.CreateCell();
                                mr.CreateCell();
                                mr.CreateCell();
                                mr.CreateCell();
                                mr.CreateCell();
                                mr.CreateCell();
                                table.AddRow(mr, table.Rows.Count - 1);
                                //XWPFTableRow newRow = table.GetRow(2);
                                //for (int j = 0; j < newRow.GetTableCells().Count; j++)
                                //{
                                //    XWPFParagraph par = doc.CreateParagraph();
                                //    XWPFRun run = par.CreateRun();
                                //    run.SetText("");
                                //    newRow.GetCell(j).SetParagraph(par);
                                //}
                                //table.AddRow(newRow, table.Rows.Count - 1);
                            }
                        }
                        int item = 0;
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            if (i >= 2 && i < table.Rows.Count - 1)
                            {
                                List<XWPFTableCell> columnsList = table.Rows[i].GetTableCells();
                                int columns = columnsList.Count;
                                for (int col = 0; col < columns; col++)
                                {
                                    if (col == 0) //序号   列
                                    {
                                        if (columnsList[col].GetText() != "")
                                        {
                                            columnsList[col].Paragraphs[0].RemoveRun(0);

                                        }
                                        columnsList[col].SetText((item + 1).ToString());
                                        string test = columnsList[col].GetText();
                                        //XWPFParagraph par = doc.CreateParagraph();
                                        //XWPFRun run = par.CreateRun();
                                        //run.SetText((item + 1).ToString());
                                        //table.Rows[i].GetCell(col).SetParagraph(par);
                                    }
                                    else if (col == 1) //检验项目
                                    {
                                        //XWPFParagraph par = doc.CreateParagraph();
                                        //XWPFRun run = par.CreateRun();
                                        //run.SetText(resultList[item].indicatorName);
                                        //table.Rows[i].GetCell(col).SetParagraph(par);
                                        columnsList[col].SetText(resultList[item].indicatorName);
                                    }
                                    else if (col == 2)//技术标准要求
                                    {
                                        //XWPFParagraph par = doc.CreateParagraph();
                                        //XWPFRun run = par.CreateRun();
                                        //run.SetText(resultList[item].indicatorDesc);
                                        //table.Rows[i].GetCell(col).SetParagraph(par);
                                        columnsList[col].SetText(resultList[item].indicatorDesc);
                                    }
                                    else if (col == 3) 
                                    {
                                        //XWPFParagraph par = doc.CreateParagraph();
                                        //XWPFRun run = par.CreateRun();
                                        //run.SetText(resultList[item].indicatorId.ToString());
                                        //table.Rows[i].GetCell(col).SetParagraph(par);
                                        columnsList[col].SetText(resultList[item].indicatorId.ToString());
                                    }
                                    else if (col == 4)
                                    {
                                        //XWPFParagraph par = doc.CreateParagraph();
                                        //XWPFRun run = par.CreateRun();
                                        //run.SetText(resultList[item].taskRecord);
                                        //table.Rows[i].GetCell(col).SetParagraph(par);
                                        columnsList[col].SetText(resultList[item].taskRecord);
                                    }
                                    else if (col == 5)
                                    {
                                        XWPFParagraph par = doc.CreateParagraph();
                                        XWPFRun run = par.CreateRun();
                                        
                                        if (resultList[item].taskResult == 2)
                                        {
                                            //run.SetText("合格");
                                            columnsList[col].SetText("合格");
                                        }
                                        else
                                        {
                                            //run.SetText("不合格");
                                            columnsList[col].SetText("不合格");
                                        }
                                        //table.Rows[i].GetCell(col).SetParagraph(par);
                                    }
                                }
                                item++;
                            }
                        }
                    }
                    if (index == 3)
                    {

                        XWPFTableCell Cell = table.GetRow(table.Rows.Count - 1).GetCell(0);//获取到进行图片插入的单元格
                        XWPFParagraph p = Cell.AddParagraph();
                        XWPFRun run = p.CreateRun();
                        foreach (var item in resultList)
                        {
                            if (item.attachment != "")
                            {
                                string path = item.attachment;
                                string[] picArr = path.Split(new char[] { ';' });
                                foreach (var str in picArr)
                                {
                                    string strTask = string.Format("/{0}/", taskId);
                                    string fileName = str.Replace(strTask, "");
                                    foreach (var picItem in picFormat)
                                    {
                                        //GetFTPFilePath();
                                        if (str.Contains(picItem))
                                        {
                                            GetFTPFilePath(str);
                                            string localFilePath = Application.StartupPath + @"\temp" + str.Replace("/", @"\");
                                            System.Drawing.Image image = System.Drawing.Image.FromFile(localFilePath);
                                            using (FileStream img = new FileStream(localFilePath, FileMode.Open, FileAccess.Read))
                                            {
                                                PictureType picType = PictureType.PNG;
                                                switch (picItem)
                                                {
                                                    case ".png":
                                                        picType = PictureType.PNG;
                                                        break;
                                                    case ".jpg":
                                                        picType = PictureType.JPEG;
                                                        break;
                                                    case ".jpeg":
                                                        picType = PictureType.JPEG;
                                                        break;
                                                    case ".bmp":
                                                        picType = PictureType.BMP;
                                                        break;
                                                    default:
                                                        break;
                                                }

                                                run.AddPicture(img, (int)picType, fileName, NPOI.Util.Units.ToEMU(image.Width), NPOI.Util.Units.ToEMU(image.Height));
                                            }
                                            //img.Close();
                                        }
                                    }
                                }
                            }
                            //string localFilePath = Application.StartupPath + @"\temp" + remoteFilePath.Replace("/", @"\");
                        }
                    }
                }
                string fileRename = string.Format("\\航科院安保设施实验室_测试报告{0}.docx", DateTime.Now.ToString("yyyyMMddHHmmss"));
                FileStream out1 = new FileStream(saveFile + fileRename, FileMode.Create,FileAccess.Write);
                doc.Write(out1);
                out1.Close();
            }
        }
        private void openRemoteFile(string remoteFilePath)
        {
            if (FtpHelper.remoteFileExists(remoteFilePath))
            {
                string localFilePath = Application.StartupPath + @"\temp" + remoteFilePath.Replace("/", @"\");
            }
        }
        private static void GetFTPFilePath(string remoteFilePath)
        {
            if (FtpHelper.remoteFileExists(remoteFilePath))
            {
                string localFilePath = Application.StartupPath + @"\temp" + remoteFilePath.Replace("/", @"\");
                string localFileFolder = Path.GetDirectoryName(localFilePath);//获取待下载文件的下载后目录，如不存在目录则先创建
                if (!Directory.Exists(localFileFolder))
                {
                    Directory.CreateDirectory(localFileFolder);
                }

                if (FtpHelper.remoteFileExists(remoteFilePath))
                {
                    if (FtpHelper.downLoad(localFilePath, remoteFilePath) == FluentFTP.FtpStatus.Failed)
                    {
                        //lbl_state.Text = "下载失败！";
                        //this.DialogResult = DialogResult.No;
                    }
                    else
                    {
                        //lbl_state.Text = "下载成功！";
                        //this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    //MessageBoxEx.Show("远程文件路径不存在。请确认远程文件路径是否正确，远程文件是否被清理或更名" + Environment.NewLine + remoteFilePath);
                }
            }
        }
    }
}
