using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord
{

    /// <summary>
    /// 新显卡的高清接口目标
    /// </summary>
    public interface IHDMIInterfaceTarget
    {
        void DisplayHDMISignal();

    }
}
