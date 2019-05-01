using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord
{
    public class HDMIInterface : IHDMIInterfaceTarget
    {
        public void DisplayHDMISignal()
        {
            Console.WriteLine("我是HDMI接口，直接可以输出HDMI信号");
        }
    }
}
