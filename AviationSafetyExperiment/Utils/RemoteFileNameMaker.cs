using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Utils
{
    public class RemoteFileNameMaker
    {
        public static string makeName(int taskId,int indicatorId,int brandId,int modelId,string extension)
        {
            return "/" + taskId + "/" + indicatorId + "_" + brandId + "_" + modelId + "-" + DateTime.Now.ToString("HHmmssfff") + extension;
        }
    }
}
