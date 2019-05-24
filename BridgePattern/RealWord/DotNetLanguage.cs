using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.RealWord
{
    /// <summary>
    /// 抽象语言类
    /// </summary>
    public abstract class DotNetLanguage
    {
        /// <summary>
        /// dotnet运行时在各个平台的实现，相当于桥梁，把语言和平台联系起来
        /// </summary>
        protected IOSPlatformRunTime oSPlatform;

        /// <summary>
        /// 设置平台（搭桥）
        /// </summary>
        /// <param name="oSPlatform"></param>
        public void SetOSPlatform(IOSPlatformRunTime oSPlatform)
        {
            this.oSPlatform = oSPlatform;
        }

        public abstract void Run();
    }
}
