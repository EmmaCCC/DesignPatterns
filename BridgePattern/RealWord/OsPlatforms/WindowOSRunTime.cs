using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.RealWord.OsPlatforms
{
    class WindowsOSRunTime : IOSPlatformRunTime
    {
        public string OSName => "Windows";

        public string Build()
        {
            //dotnet运行时一顿操作，返回一个正确的文件类型
            return "test.exe";
        }
    }
}
