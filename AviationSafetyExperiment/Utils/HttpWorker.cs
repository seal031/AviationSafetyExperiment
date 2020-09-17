using AviationSafetyExperiment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Utils
{
    public class HttpWorker
    {
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
    }
}
