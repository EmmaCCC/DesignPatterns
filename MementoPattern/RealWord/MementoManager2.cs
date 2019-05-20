using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.RealWord
{
    /// <summary>
    /// 备忘录管理器（存备忘录的地方）
    /// </summary>
    public class MementoManager2
    {
        /// <summary>
        /// 这里我们可以存储一个备忘录字典，每一次操作后就把操作之前的接口按一个key值（或时间点存起来），这样我们就能指定恢复到某一个还原点了。
        /// </summary>
        public static Dictionary<string, ContactPersonMemento> ContactPersonMementoDic { get; set; }
    }
}
