using AviationSafetyExperiment.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviationSafetyExperiment.Utils
{
    public class HttpWorker
    {
        static string loginUrl, userListUrl;
        static HttpWorker()
        {
            loginUrl = ConfigWorker.GetConfigValue("loginUrl");
            userListUrl = ConfigWorker.GetConfigValue("userListUrl");
        }

        public static void getUser(string username)
        {
            User user = new Model.User()
            {
                id = "1",
                name = "张三",
                departmentId = "101",
                departmentName = "部门一",
                indentity=UserIdentityEnum.Test_Officers
            };
            User user1 = new Model.User()
            {
                id = "2",
                name = "李四",
                departmentId = "101",
                departmentName = "部门一",
                indentity = UserIdentityEnum.Test_Officers
            };
            User user2 = new Model.User()
            {
                id = "3",
                name = "王五",
                departmentId = "102",
                departmentName = "部门二",
                indentity = UserIdentityEnum.Test_Officers
            };
            User user3 = new Model.User()
            {
                id = "2",
                name = "齐可新",
                departmentId = "101",
                departmentName = "部门一",
                indentity = UserIdentityEnum.Test_Officers
            };
            User user4 = new Model.User()
            {
                id = "3",
                name = "陈亮",
                departmentId = "102",
                departmentName = "部门二",
                indentity = UserIdentityEnum.Approving_Officers
            };
            User.add(user);
            User.add(user1);
            User.add(user2);
            User.add(user3);
            User.add(user4);
            switch (username)
            {
                case "cl":
                    User.currentUser = user4;
                    break;
                default:
                    User.currentUser = user3;
                    break;
            }
        }

        public static bool login(string username,string password)
        {
            try
            {
                //导入公钥 加密
                string publicKey = @"MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCqRK6V0ylacNFH+K7b/PG9txPzXk69gjslEi5N16CQUUHh6aVhhsyj7aAKDTEp76odCdi0tIlv3FTuW41G8ma+QKGChOF+036a3DoKysDHrkuaB5o//jDBfE48mGtNZt4chsJdvYEDsj7StmsZPW5wuQoJzvzZu4oKO5SRZzjDPQIDAQAB"; 
                string RsaPassword = RsaWorker.EncryptByPublicKey(password + "," + RsaWorker.GetTimeStamp(), publicKey);
                string head = "{\"loginName\": \"" + username + "\",\"loginPass\": \"" + RsaPassword + "\"}";
                string response = PostByHttpClient(loginUrl, head);
                HttpEntity httpEntity = HttpEntity.fromJson(response);
                if (httpEntity.resultCode == 200)
                {
                    User user = new Model.User();
                    user.id = httpEntity.data.userVo.uuid;
                    user.departmentId = httpEntity.data.userVo.departmentId;
                    user.departmentName = httpEntity.data.userVo.departmentName;
                    user.cookieValue = response;//将cookie值设为请求返回的全部内容即可
                    user.indentity = (httpEntity.data.userVo.userType == "1" ? UserIdentityEnum.Approving_Officers : UserIdentityEnum.Test_Officers);
                    user.name = httpEntity.data.userVo.userName;
                    User.add(user);
                    User.currentUser = user;
                    return true;
                }
                else
                {
                    MessageBox.Show("用户登录失败：" + httpEntity.msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("用户登录失败：" + ex.Message);
                return false;
            }
        }

        public static bool getUserList()
        {
            try
            {
                string response = PostByHttpClient(userListUrl, "");
                HttpEntity httpEntity = HttpEntity.fromJson(response);
                if (httpEntity.resultCode == 200)
                {
                    foreach (var data in httpEntity.datalist)
                    {
                        try
                        {
                            User user = new User();
                            user.id = data.uuid;
                            user.departmentId = data.departmentId;
                            user.departmentName = data.departmentName;
                            user.indentity = data.userType == "1" ? UserIdentityEnum.Approving_Officers : UserIdentityEnum.Test_Officers;
                            user.name = data.userName;
                            User.add(user);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("获取用户信息列表失败：" + httpEntity.msg);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取用户信息列表失败：" + ex.Message);
                return false;
            }
        }

        public static string PostByHttpClient(string url, string head)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
            HttpContent content = new StringContent(head, Encoding.UTF8);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync(url, content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            return responseString;
        }
    }

    public class HttpEntity
    {
        public DataEntity data { get; set; } 
        public List<DatalistEntity> datalist { get; set; }
        public string msg { get; set; }
        public string page { get; set; }
        public int resultCode { get; set; }

        public static HttpEntity fromJson(string json)
        {
            return JsonConvert.DeserializeObject<HttpEntity>(json);
        }
    }

    public class DataEntity
    {
        public string loginKey { get; set; }
        public string loginValue { get; set; }
        public UserVo userVo { get; set; }
        public class UserVo
        {
            public string adminFlag { get; set; }
            public int cameraPriority { get; set; }
            public string createBy { get; set; }
            public string createDate { get; set; }
            public string deleteFlag { get; set; }
            public string departmentId { get; set; }
            public string departmentName { get; set; }
            public string email { get; set; }
            public string loginName { get; set; }
            public string mobile { get; set; }
            public string operationType { get; set; }
            public string sexCode { get; set; }
            public string updateBy { get; set; }
            public string updateDate { get; set; }
            public string userLoginFlag { get; set; }
            public string userName { get; set; }
            public string userNumber { get; set; }
            public string userPicId { get; set; }
            public string userState { get; set; }
            public string userType { get; set; }
            public string uuid { get; set; }
        }
    }
    public class DatalistEntity
    {
        public string createBy { get; set; }
        public string createDate { get; set; }
        public string deleteFlag { get; set; }
        public string departmentId { get; set; }
        public string departmentName { get; set; }
        public string email { get; set; }
        public string loginName { get; set; }
        public string loginPass { get; set; }
        public string mobile { get; set; }
        public string operationType { get; set; }
        public string sexCode { get; set; }
        public string updateBy { get; set; }
        public string updateDate { get; set; }
        public string userName { get; set; }
        public string userNumber { get; set; }
        public string userPicId { get; set; }
        public string userState { get; set; }
        public string userType { get; set; }
        public string uuid { get; set; }
    }
}
