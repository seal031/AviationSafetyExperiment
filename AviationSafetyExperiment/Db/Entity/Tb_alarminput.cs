using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public class Tb_alarminput:BaseEntity
    {
        /// <summary>
        /// 测试id
        /// </summary>
        public int taskId { get; set; }
        /// <summary>
        /// Tb_result数据表的Id
        /// </summary>
        public int resultId { get; set; }
        /// <summary>
        /// 报警类型
        /// </summary>
        public string alarmType { get; set; }
        /// <summary>
        /// 报警形式
        /// </summary>
        public string alarmForm { get; set; }
        /// <summary>
        /// 报警分类
        /// </summary>
        public string classify { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string describe { get; set; }
    }
}
