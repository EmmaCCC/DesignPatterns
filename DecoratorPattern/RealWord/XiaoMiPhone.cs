using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.RealWord
{
    /// <summary>
    /// 小米手机继承手机类
    /// </summary>
    public class XiaoMiPhone:Phone
    {
        public override void Show()
        {
            Console.WriteLine("小米裸机，什么都没有");
        }
    }
}
