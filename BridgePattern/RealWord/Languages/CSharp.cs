using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.RealWord.Languages
{
    public class CSharp:DotNetLanguage
    {
        public override void Run()
        {
            Console.WriteLine($"语言:C#,平台：{this.oSPlatform.OSName},结果" + this.oSPlatform.Build());

        }
    }
}
