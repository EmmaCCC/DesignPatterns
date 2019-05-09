using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SimpleFactory
{
    /// <summary>
    /// 小米手机8
    /// </summary>
    public class XiaoMi8 :XiaoMiPhone
    {
        public override string GetPhoneInfo()
        {
            return "XiaoMi8 2899元";
        }
    }
}
