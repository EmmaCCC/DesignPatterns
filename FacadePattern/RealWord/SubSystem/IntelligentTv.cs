using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.RealWord.SubSystem
{
    /// <summary>
    /// 智能电视
    /// </summary>
    public class IntelligentTv
    {
        public void On()
        {
            Console.WriteLine("电视打开");
        }

        public void Off()
        {
            Console.WriteLine("电视关闭");
        }
    }
}
