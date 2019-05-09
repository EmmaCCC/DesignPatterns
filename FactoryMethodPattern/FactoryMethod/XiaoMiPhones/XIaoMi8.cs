using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod.XiaoMiPhones
{
    public class XiaoMi8:XiaoMiPhone
    {
        public override string GetPhoneInfo()
        {
            return "Mi8 2699元";
        }
    }
}
