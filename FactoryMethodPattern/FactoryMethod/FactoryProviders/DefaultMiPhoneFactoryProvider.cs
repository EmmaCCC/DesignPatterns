using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.FactoryMethod.XiaoMiPhones;

namespace FactoryMethodPattern.FactoryMethod.FactoryProviders
{
    public class DefaultMiPhoneFactoryProvider: XiaoMiPhoneFactoryProvider
    {
        public override XiaoMiPhone GetPhone()
        {
            return new DafaultXiaoMiPhoneMix2();
        }
    }
}
