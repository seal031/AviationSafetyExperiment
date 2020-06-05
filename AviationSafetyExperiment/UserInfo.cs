using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment
{
    public static class UserInfo
    {
        /// <summary>
        /// 用户身份
        /// </summary>
        public static UserIdentityEnum indentity { get; set; }

        public static string userName { get; set; }

        public static string userId { get; set; }
    }

    /// <summary>
    /// 用户身份
    /// </summary>
    public enum UserIdentityEnum
    {
        /// <summary>
        /// 审批人员
        /// </summary>
        Approving_Officers,
        /// <summary>
        /// 测试人员
        /// </summary>
        Test_Officers
    }
}
