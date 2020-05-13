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
        public string indicatorName { get; set; }
        public string indicatorDesc { get; set; }
        public string isObsolete { get; set; }
    }
}
