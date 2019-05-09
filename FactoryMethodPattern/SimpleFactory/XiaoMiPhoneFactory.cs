using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SimpleFactory
{
    /// <summary>
    /// 小米手机抽象类
    /// </summary>
    public  class XiaoMiPhoneFactory
    {
        public static XiaoMiPhone GetPhone(PhoneType type)
        {
            switch (type)
            {
                case PhoneType.XiaoMi8:
                {
                    return new XiaoMi8();
                }

                case PhoneType.XiaoMi9:
                {
                    return new XiaoMi9();
                }
                default:
                {
                        return null;
                }
            }
        }
    }
}
