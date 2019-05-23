using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.RealWord.SubSystem
{
    /// <summary>
    /// 智能电灯
    /// </summary>
    public class IntelligentLight
    {
        public void On()
        {
            Console.WriteLine("电灯打开");
        }

        public void Off()
        {
            Console.WriteLine("电灯关闭");
        }
    }
}
