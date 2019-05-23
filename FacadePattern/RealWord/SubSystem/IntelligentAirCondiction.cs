using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.RealWord.SubSystem
{
    /// <summary>
    /// 智能空调
    /// </summary>
    public class IntelligentAirCondiction
    {
        public void On()
        {
            Console.WriteLine("空调打开");
        }

        public void Off()
        {
            Console.WriteLine("空调关闭");
        }
    }
}
