using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealWord.Decorators
{
    /// <summary>
    /// 贴膜类，继承装饰器类
    /// </summary>
    public class Sticker:PhoneDecorator
    {
        public Sticker(Phone phone) : base(phone)
        {

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("添加了手机贴膜");
        }
    }
}
