using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.FactoryMethod.XiaoMiPhones;

namespace FactoryMethodPattern.FactoryMethod.FactoryProviders
{
    public class XiaoMi8FactoryProvider: XiaoMiPhoneFactoryProvider
    {
        public override XiaoMiPhone GetPhone()
        {
            return new XiaoMi8();
        }
    }
}
