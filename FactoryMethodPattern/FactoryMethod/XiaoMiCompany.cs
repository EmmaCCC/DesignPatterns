using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.FactoryMethod.FactoryProviders;

namespace FactoryMethodPattern.FactoryMethod
{
    public class XiaoMiCompany
    {
        private XiaoMiPhoneFactoryProvider _provider;

        public XiaoMiCompany()
        {
            this._provider = new DefaultMiPhoneFactoryProvider();
        }
        public void SetXiaoMiPhoneFactoryProvider(XiaoMiPhoneFactoryProvider provider)
        {
            this._provider = provider;
        }

        public void DisplayPhoneInfo()
        {
            Console.WriteLine(this._provider.GetPhone().GetPhoneInfo());
        }
    }
}
