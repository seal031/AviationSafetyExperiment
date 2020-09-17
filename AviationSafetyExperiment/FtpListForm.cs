using AviationSafetyExperiment.Db.Entity;
using AviationSafetyExperiment.Utils;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    public partial class FtpListForm : Office2007Form
    {
        int taskId, indicatorId, brandId, modelId;
        bool readOnly = false;
        List<string> remoteFileList=new List<string>();
        ProgressBarItem pb;
        private ResultSupplement supplement;

        public FtpListForm(int _taskId, int _indicatorId, int _brandId, int _modelId, string remoteFiles)
        {
            InitializeComponent();
            taskId = _taskId;
            indicatorId = _indicatorId;
            brandId = _brandId;
            modelId = _modelId;
            foreach (string remoteFile in remoteFiles.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                remoteFileList.Add(remoteFile);
                addIc(remoteFile,true);
            }
        }
        /// <summary>
        /// 只读模式的构造函数
        /// </summary>
        /// <param name="remoteFiles"></param>
        public FtpListForm(string remoteFiles,string supplementJsonString)
        {
            InitializeComponent();
            readOnly = true;
            foreach (string remoteFile in remoteFiles.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
                remoteFileList.Add(remoteFile);
                addIc(remoteFile, true);
            }
            btn_openFileDialog.Enabled = false;
            try
            {
                supplement = ResultSupplement.fromJson(supplementJsonString);
            }
            catch (Exception ex)
            {
                supplement = null;
            }
            if (supplement != null)
            {
                txt_alarmType.Text = supplement.alarmType;
                txt_alarmForm.Text = supplement.alarmForm;
                ii_testCount.Text = supplement.totalTest.ToString();
                ii_alarmCount.Text = supplement.alarmTest.ToString();
                ii_omitCount.Text = supplement.omitCount.ToString();
                ii_misinformationCount.Text = supplement.misinformationCount.ToString();
                ii_usableCount.Text = supplement.usableCount.ToString();
            }
        }

        public string remoteFiles
        {
            get
            {
                return string.Join(";", remoteFileList);
            }
        }

        private void FtpListForm_Shown(object sender, EventArgs e)
        {
            FtpHelper.processChangeEvent += FtpHelper_processChangeEvent;
        }
        private void FtpHelper_processChangeEvent(FluentFTP.FtpProgress process)
        {
            if (pb != null)
            {
                setPbPrecess((int)process.Progress);
            }
        }
        private delegate void delPbProcess(int value);
        public void setPbPrecess(int value)
        {
            if (pb.InvokeRequired)//其它线程调用  
            {
                delPbProcess d = new delPbProcess(setPbPrecess);
                pb.Invoke(d, new object[] { value });
            }
            else//本线程调用  
            {
                pb.Value = value;
                pb.Text = value + "%";
                pb.Refresh();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_openFileDialog_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string localFilePath in ofd.FileNames)
                {
                    string extension = Path.GetExtension(localFilePath);
                    string remoteFilePath = RemoteFileNameMaker.makeName(taskId, indicatorId, brandId, modelId, extension);
                    addIc(remoteFilePath);
                    upload(localFilePath, remoteFilePath);
                }
            }
        }

        private void addIc(string remoteFilePath,bool exists=false)
        {
            ItemContainer ic = new ItemContainer();
            LabelItem labelItem = new LabelItem();
            labelItem.Width = 250;
            labelItem.Text = remoteFilePath;
            ProgressBarItem progressBarItem = new ProgressBarItem();
            progressBarItem.BackStyle.Class = "";
            progressBarItem.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            progressBarItem.ChunkGradientAngle = 0F;
            progressBarItem.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            progressBarItem.RecentlyUsed = false;
            progressBarItem.TextVisible = true;
            progressBarItem.Width = 120;
            if (exists)
            {
                progressBarItem.Value = 100;
                progressBarItem.Text = "上传成功";
            }
            else
            {
                pb = progressBarItem;//赋给全局进度条
            }
            if (readOnly)
            {
                LabelItem buttonItem = new LabelItem();
                buttonItem.Text = "无";
                buttonItem.Tooltip = "无操作";
                ic.SubItems.AddRange(new BaseItem[] { labelItem, progressBarItem, buttonItem });
            }
            else
            {
                ButtonItem buttonItem = new ButtonItem();
                buttonItem.Image = global::AviationSafetyExperiment.Properties.Resources.s_25;
                buttonItem.Text = "移除";
                buttonItem.Tooltip = "移除";
                buttonItem.Click += ButtonItemClear_Click;
                ic.SubItems.AddRange(new BaseItem[] { labelItem, progressBarItem, buttonItem });
            }

            labelItem.DoubleClick += Li_DoubleClick;
            progressBarItem.DoubleClick += Pbi_DoubleClick;
            ic.DoubleClick += Ic_DoubleClick;
            ic.Name = remoteFilePath;

            ip.Items.Add(ic);
            ip.Refresh();
        }

        private void upload(string localFilePath, string remoteFilePath)
        {
            if (localFilePath != null && remoteFilePath != null)
            {
                if (File.Exists(localFilePath))
                {
                    if (FtpHelper.upload(localFilePath, remoteFilePath) == FluentFTP.FtpStatus.Failed)
                    {
                        pb.Text = "上传失败！";
                        //this.DialogResult = DialogResult.No;
                    }
                    else
                    {
                        pb.Text = "上传成功！";
                        remoteFileList.Add(remoteFilePath);
                        //this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBoxEx.Show("待上传文件路径不正确，无法在本地找到该文件" + Environment.NewLine + localFilePath);
                }
            }
            else
            {
                MessageBoxEx.Show("待上传文件和上传路径不能为空");
            }
        }
        /// <summary>
        /// 移除按钮事件。从控件中移除ic；从FTP删除远程文件；从remoteFileList中移除远程文件名；
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonItemClear_Click(object sender, EventArgs e)
        {
            if (readOnly == false)
            {
                ButtonItem buttonItem = sender as ButtonItem;
                ItemContainer ic = buttonItem.Parent as ItemContainer;
                ip.Items.Remove(ic);
                ip.Refresh();
                if (FtpHelper.remoteFileExists(ic.Name))
                {
                    FtpHelper.deleteFile(ic.Name);
                }
                if (remoteFileList.Contains(ic.Name))
                {
                    remoteFileList.Remove(ic.Name);
                }
            }
        }
        /// <summary>
        /// ic双击事件。打开附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ic_DoubleClick(object sender, EventArgs e)
        {
            ItemContainer ic = sender as ItemContainer;
            if (ic != null)
            {
                string remoteFilePath = ic.Name;
                openRemoteFile(remoteFilePath);
            }
        }
        private void Li_DoubleClick(object sender, EventArgs e)
        {
            LabelItem li = sender as LabelItem;
            ItemContainer ic = li.Parent as ItemContainer;
            if (ic != null)
            {
                string remoteFilePath = ic.Name;
                openRemoteFile(remoteFilePath);
            }
        }
        public void Pbi_DoubleClick(object sender, EventArgs e)
        {
            ProgressBarItem pbi = sender as ProgressBarItem;
            ItemContainer ic = pbi.Parent as ItemContainer;
            if (ic != null)
            {
                string remoteFilePath = ic.Name;
                openRemoteFile(remoteFilePath);
            }
        }

        private void openRemoteFile(string remoteFilePath)
        {
            if (FtpHelper.remoteFileExists(remoteFilePath))
            {
                string localFilePath = Application.StartupPath + @"\temp" + remoteFilePath.Replace("/", @"\");
                string localFileFolder = Path.GetDirectoryName(localFilePath);//获取待下载文件的下载后目录，如不存在目录则先创建
                if (!Directory.Exists(localFileFolder))
                {
                    Directory.CreateDirectory(localFileFolder);
                }
                FtpProcessForm fpf = new FtpProcessForm(localFilePath, remoteFilePath, false);
                var downloadState = fpf.ShowDialog();
                if (downloadState == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("explorer.exe", localFilePath);//打开下载的文件
                }
                else
                {
                    MessageBoxEx.Show("下载附件失败");
                }
            }
        }
    }
}
