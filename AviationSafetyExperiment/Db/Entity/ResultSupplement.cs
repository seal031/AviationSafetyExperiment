using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    public static class JsonSerializer
    {
        static JsonSerializerSettings jssIgnore = new JsonSerializerSettings();

        public static JsonSerializerSettings IgnoreSerializerSetting
        {
            get
            {
                jssIgnore.NullValueHandling = NullValueHandling.Ignore;
                return jssIgnore;
            }
        }
    }

    public class ResultSupplement
    {
        /// <summary>
        /// 报警类型
        /// </summary>
        public string alarmType { get; set; }
        /// <summary>
        /// 报警形式
        /// </summary>
        public string alarmForm { get; set; }
        /// <summary>
        /// 总测试数量
        /// </summary>
        public int totalTest { get; set; }
        /// <summary>
        /// 测试报警数量
        /// </summary>
        public int alarmTest { get; set; }
        /// <summary>
        /// 漏报数量
        /// </summary>
        public int omitCount { get; set; }
        /// <summary>
        /// 正常报警数量
        /// </summary>
        public int usableCount { get; set; }
        /// <summary>
        /// 误报数量
        /// </summary>
        public int misinformationCount { get; set; }

        public string toJson()
        {
            return JsonConvert.SerializeObject(this, JsonSerializer.IgnoreSerializerSetting);
        }

        public static ResultSupplement fromJson(string json)
        {
            return JsonConvert.DeserializeObject<ResultSupplement>(json);
        }
    }
}
