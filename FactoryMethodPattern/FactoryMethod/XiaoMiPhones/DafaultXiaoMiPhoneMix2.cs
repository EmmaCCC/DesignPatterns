using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryMethod.XiaoMiPhones
{
    public class DafaultXiaoMiPhoneMix2 : XiaoMiPhone
    {
        public override string GetPhoneInfo()
        {
            return "默认 Mix2 3199元";
        }
    }
}
