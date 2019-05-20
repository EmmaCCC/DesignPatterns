using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.RealWord
{
    /// <summary>
    /// 备忘录管理器（存备忘录的地方）
    /// </summary>
    public class MementoManager
    {
        public static ContactPersonMemento ContactPersonMemento { get; set; }
    }
}
