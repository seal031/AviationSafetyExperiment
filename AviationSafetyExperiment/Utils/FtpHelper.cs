using DevComponents.DotNetBar;
using FluentFTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment.Utils
{
    public class FtpHelper
    {
        static FtpClient client;

        public delegate void processDelegate(FtpProgress process);
        public static event processDelegate processChangeEvent;

        static FtpHelper()
        {
            try
            {
                string ftpServer = ConfigWorker.GetConfigValue("ftpServer");
                int ftpPort = int.Parse(ConfigWorker.GetConfigValue("ftpPort"));
                string ftpUser = ConfigWorker.GetConfigValue("ftpUser");
                string ftpPwd = ConfigWorker.GetConfigValue("ftpPwd");
                client = new FtpClient(ftpServer, ftpPort, ftpUser, ftpPwd);
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("实例化FTP客户端失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 文件传输回调方法
        /// </summary>
        private static Action<FtpProgress> progress = new Action<FtpProgress>(x =>
        {
            //当进度未知的时候，会收到-1
            if (x.Progress < 0)
            {
                //progressBar.IsIndeterminate = true;
            }
            else
            {
                //progressBar.IsIndeterminate = false;
                //progressBar.Value = x;
                processChangeEvent(x);
            }
        });
        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="localFilePath"></param>
        /// <param name="remoteFilePath"></param>
        /// <returns></returns>
        public static FtpStatus upload(string localFilePath, string remoteFilePath)
        {
            try
            {
                client.Connect();
                var state = client.UploadFile(localFilePath, remoteFilePath, existsMode: FtpRemoteExists.Overwrite, createRemoteDir: true, verifyOptions: FtpVerify.None, progress: progress);
                client.Disconnect();
                return state;
            }
            catch (Exception ex)
            {
                return FtpStatus.Failed;
            }
        }
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="localFilePath"></param>
        /// <param name="remoteFilePath"></param>
        /// <returns></returns>
        public static FtpStatus downLoad(string localFilePath, string remoteFilePath)
        {
            client.Connect();
            var state = client.DownloadFile(localFilePath, remoteFilePath, existsMode: FtpLocalExists.Overwrite, verifyOptions: FtpVerify.None, progress: progress);
            client.DisableUTF8();
            return state;
        }
        /// <summary>
        /// 远程文件是否存在
        /// </summary>
        /// <param name="remoteFilePath"></param>
        /// <returns></returns>
        public static bool remoteFileExists(string remoteFilePath)
        {
            client.Connect();
            bool exists = client.FileExists(remoteFilePath);
            client.Disconnect();
            return exists;
        }
        /// <summary>
        /// 删除远程文件
        /// </summary>
        /// <param name="remoteFilePath"></param>
        public static void deleteFile(string remoteFilePath)
        {
            if (remoteFileExists(remoteFilePath))
            {
                client.DeleteFile(remoteFilePath);
            }
        }
    }
}
