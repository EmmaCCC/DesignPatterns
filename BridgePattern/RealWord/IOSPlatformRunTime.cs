using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.RealWord
{
    /// <summary>
    /// 抽象平台运行时（桥梁）
    /// </summary>
    public interface IOSPlatformRunTime
    {
        string OSName { get;}
        string Build();
    }
}
