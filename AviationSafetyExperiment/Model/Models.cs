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
        public string indicatorInstr { get; set; }
        public string isObsolete { get; set; }
    }

    public class IndicatorForTemplateModel : IndicatorModel
    {
        /// <summary>
        /// 是否被选中，用于指标模板中切换指标状态时，记录指标是否被选择，以免datasource刷新后，用户已勾选的指标消失。默认false
        /// </summary
        public bool isSelected { get; set; } = false;
    }
    public class RoundIndicatorModel : IndicatorModel
    {
        /// <summary>
        /// 是否被选中，用于指标模板中切换指标状态时，记录指标是否被选择，以免datasource刷新后，用户已勾选的指标消失。默认false
        /// </summary
        public bool isSelected { get; set; } = false;
        /// <summary>
        /// 品牌Id
        /// </summary>
        public int brandId { get; set; }
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// 型号Id
        /// </summary>
        public int modelId { get; set; }
        /// <summary>
        /// 型号名称
        /// </summary>
        public string modelName { get; set; }
        /// <summary>
        /// 步骤
        /// </summary>
        public int taskStep { get; set; }
    }

    /// <summary>
    /// 任务列表使用的模型
    /// </summary>
    public class TaskModel
    {
        public int taskId { get; set; }
        public string taskName { get; set; }
        public string taskBrandModelName { get; set; }
        public string taskClassName { get; set; }
        public DateTime taskStartTime { get; set; }
        public string taskCode { get; set; }
        public int taskStateId { get; set; }

        public string taskStateName { get; set; }
        public int percent { get; set; }
    }

    /// <summary>
    /// 任务测试结果使用模型
    /// </summary>
    public class TaskResultModel
    {
        public int indicatorId { get; set; }
        public string indicatorName { get; set; }

        public string indicatorDesc { get; set; }
        public string indicatorInstr { get; set; }
        public int brandId { get; set; }
        public string brandName { get; set; }
        public int modelId { get; set; }
        public string modelName { get; set; }
        public int taskStep { get; set; } 
        public string taskExecutor { get; set; }
        public string taskDateTime { get; set; }
        public string taskRecord { get; set; }
        /// <summary>
        /// 测试结果值  0未通过  1通过
        /// </summary>
        public int taskResult { get; set; }
        /// <summary>
        /// 测试结果的主键
        /// </summary>
        public int taskResultId { get; set; }
        public string taskRemark { get; set; }
        public string attachment { get; set; }

        public string attachmentCount { get; set; }
        /// <summary>
        /// 补充内容，包括漏报补报。json格式
        /// </summary>
        public string supplement { get; set; }
        /// <summary>
        /// 判断内容是否已经填写完成,用于完成任务和新增轮次的判断
        /// </summary>
        public int isFillFinish { get; set; }
        /// <summary>
        /// 判断当前是否已修改过值,不管修改了那个值,都为1,未修改为0
        /// </summary>
        public int isHaveModi { get; set;}
    }
}
