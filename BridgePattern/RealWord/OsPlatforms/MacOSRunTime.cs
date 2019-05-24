using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.RealWord.OsPlatforms
{
    class MacOSRunTime : IOSPlatformRunTime
    {
        public string OSName => "Mac";

        public string Build()
        {
            //dotnet运行时一顿操作，返回一个正确的文件类型
            return "test.app";
        }
    }
}
