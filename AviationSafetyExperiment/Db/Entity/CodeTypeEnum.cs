using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public enum CodeTypeEnum
    {
        /// <summary>
        /// 品牌
        /// </summary>
        Brand=1,
        /// <summary>
        /// 型号
        /// </summary>
        Model=2,
        /// <summary>
        /// 测试分类
        /// </summary>
        Class=3,
        /// <summary>
        /// 测试类型
        /// </summary>
        Type=4,
        /// <summary>
        /// 任务状态
        /// </summary>
        State=5,
    }
}
