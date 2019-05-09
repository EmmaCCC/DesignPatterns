using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SimpleFactory
{
    /// <summary>
    /// 小米手机9
    /// </summary>
    public class XiaoMi9 : XiaoMiPhone
    {
        public override string GetPhoneInfo()
        {
            return "XiaoMi9 3299元";
        }
    }
}
