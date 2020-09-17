using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Model
{
    /// <summary>
    /// 用户对象。从web接口获取
    /// </summary>
    public class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string departmentId { get; set; }
        public string departmentName { get; set; }
        /// <summary>
        /// 用户身份
        /// </summary>
        public UserIdentityEnum indentity { get; set; }
        /// <summary>
        /// 当前登录用户
        /// </summary>
        public static User currentUser { get; set; }
        public static List<User> list = new List<User>();
        public static void add(User user)
        {
            var tempUser = list.FirstOrDefault(u => u.id == user.id);
            if (tempUser == null)
            {
                list.Add(user);
            }
            else
            {
                tempUser.name = user.name;
                tempUser.departmentId = user.departmentId;
                tempUser.departmentName = user.departmentName;
                tempUser.indentity = user.indentity;
            }
        }
    }
    /// <summary>
    /// 用户身份
    /// </summary>
    public enum UserIdentityEnum
    {
        /// <summary>
        /// 具有审批权限的人员
        /// </summary>
        Approving_Officers,
        /// <summary>
        /// 测试人员
        /// </summary>
        Test_Officers
    }
}
