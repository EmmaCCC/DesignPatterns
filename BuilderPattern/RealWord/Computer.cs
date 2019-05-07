using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.RealWord
{
    public class Computer
    {
        public string Cpu { get; set; }

        public string Graphics { get; set; }

        public string Memory { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Cpu:{Cpu}");
            Console.WriteLine($"显卡:{Graphics}");
            Console.WriteLine($"内存条:{Memory}");
        }
    }
}
