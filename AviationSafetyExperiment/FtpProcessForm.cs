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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment
{
    public partial class FtpProcessForm : Form
    {
        private string localFilePath, remoteFilePath;
        /// <summary>
        /// true上传；false下载
        /// </summary>
        private bool isUpload;

        public FtpProcessForm(string _loaclFilePath,string _remoteFilePath,bool _isUpload)
        {
            InitializeComponent();
            this.localFilePath = _loaclFilePath;
            this.remoteFilePath = _remoteFilePath;
            this.isUpload = _isUpload;
        }

        private void upload()
        {
            if (localFilePath != null && remoteFilePath != null)
            {
                if (File.Exists(localFilePath))
                {
                    if (FtpHelper.upload(localFilePath, remoteFilePath) == FluentFTP.FtpStatus.Failed)
                    {
                        lbl_state.Text = "上传失败！";
                        this.DialogResult = DialogResult.No;
                    }
                    else
                    {
                        lbl_state.Text = "上传成功！";
                        this.DialogResult = DialogResult.OK;
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

        private void download()
        {
            if (localFilePath != null && remoteFilePath != null)
            {
                if (FtpHelper.remoteFileExists(remoteFilePath))
                {
                    if (FtpHelper.downLoad(localFilePath, remoteFilePath) == FluentFTP.FtpStatus.Failed)
                    {
                        lbl_state.Text = "下载失败！";
                        this.DialogResult = DialogResult.No;
                    }
                    else
                    {
                        lbl_state.Text = "下载成功！";
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBoxEx.Show("远程文件路径不存在。请确认远程文件路径是否正确，远程文件是否被清理或更名" + Environment.NewLine + remoteFilePath);
                }
            }
            else
            {
                MessageBoxEx.Show("待下载文件和保存路径不能为空");
            }
        }

        private void FtpProcessForm_Shown(object sender, EventArgs e)
        {
            FtpHelper.processChangeEvent += FtpHelper_processChangeEvent;
            if (isUpload)
            {
                upload();//打开窗体就开始上传
            }
            else
            {
                download();//打开窗体就开始下载
            }
        }

        private void FtpHelper_processChangeEvent(FluentFTP.FtpProgress process)
        {
            //pb.Value = (int)process.Progress;
            //pb.Text = ((int)process.Progress).ToString() + "%";
            setPbPrecess((int)process.Progress);
            if (process.Progress == 100)
            {
                lbl_state.Text = "传输完成";
                Thread.Sleep(1000);
                this.Close();
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
    }
}
