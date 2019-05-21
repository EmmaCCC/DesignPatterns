using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealWord
{
    /// <summary>
    /// 装饰抽象类,要让装饰完全取代抽象组件，就要继承Phone（也可以理解为装饰器装饰过的手机还是手机，这里我们以装饰过的手机为核心对象）
    /// 包含一个手机的引用，后续装饰者同样是这样，然后就能一直以包装的形式包装下去
    /// </summary>
    public abstract class PhoneDecorator:Phone
    {
        private Phone _phone;
        protected PhoneDecorator(Phone phone)
        {
            this._phone = phone;
        }
        public override void Show()
        {
            _phone?.Show();
        }
    }
}
