using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibilityPattern.RealWord
{
    /// <summary>
    /// 请假请求
    /// </summary>
    public class LeaveRequest
    {
        /// <summary>
        /// 请假人
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 请假天数
        /// </summary>
        public int Day { get; set; }
    }
}
