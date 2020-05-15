using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Model
{
    public class IndicatorModel
    {
        public int indicatorId { get; set; }
        public int classId { get; set; }
        public string className { get; set; }
        public int detectionId { get; set; }
        public string detectionName { get; set; }
        public int subDetectionId { get; set; }
        public string subDetectionName { get; set; }
        public string indicatorName { get; set; }
        public string indicatorDesc { get; set; }
        public string isObsolete { get; set; }
    }

    public class IndicatorForTemplateModel : IndicatorModel
    {
        /// <summary>
        /// 是否被选中，用于指标模板中切换指标状态时，记录指标是否被选择，以免datasource刷新后，用户已勾选的指标消失。默认false
        /// </summary
        public bool isSelected { get; set; } = false;
    }
}
