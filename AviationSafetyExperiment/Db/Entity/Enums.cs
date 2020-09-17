using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Db.Entity
{
    /// <summary>
    /// 代码分类枚举
    /// </summary>
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
        /// <summary>
        /// 检测内容
        /// </summary>
        Detection=6,
        /// <summary>
        /// 检测分项
        /// </summary>
        SubDetection=7,
    }
    /// <summary>
    /// 任务状态枚举
    /// </summary>
    public enum TaskStateEnum
    {
        /// <summary>
        /// 已创建
        /// </summary>
        Created=5001,
        /// <summary>
        /// 已通过
        /// </summary>
        Passed=5002,
        /// <summary>
        /// 已驳回
        /// </summary>
        Rejected=5003,
        /// <summary>
        /// 已开始
        /// </summary>
        Running=5004,
        /// <summary>
        /// 已完成
        /// </summary>
        Completed=5005,
        /// <summary>
        /// 已关闭
        /// </summary>
        Closed=5006
    }
    /// <summary>
    /// 任务列表按钮显示style枚举
    /// </summary>
    public enum TaskGridShownStyle
    {
        /// <summary>
        /// 隐藏所有按钮
        /// </summary>
        HideAll,
        /// <summary>
        /// 新任务（审批人员显示通过、驳回按钮；测试人员显示打开任务按钮）
        /// </summary>
        NewTask,
        /// <summary>
        /// 正在执行的任务（测试人员显示打开任务按钮）
        /// </summary>
        RunningTask,
        /// <summary>
        /// 已完成任务（隐藏所有按钮）
        /// </summary>
        DoneTask,
        /// <summary>
        /// 已关闭任务（隐藏所有按钮）
        /// </summary>
        CloseTask
    }
}
