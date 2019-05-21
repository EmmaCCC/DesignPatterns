using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealWord.Decorators
{
    /// <summary>
    /// 手机护套，继承装饰器类
    /// </summary>
    public class Cover: PhoneDecorator
    {
        public Cover(Phone phone) : base(phone)
        {
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("添加了手机护套");
        }
    }
}
