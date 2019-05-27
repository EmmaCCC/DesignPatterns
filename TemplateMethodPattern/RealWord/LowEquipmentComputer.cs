using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.RealWord
{
    public class LowEquipmentComputer : ComputerDIY
    {
        public override void BuyCpu()
        {
            Console.WriteLine("i3 6100");
        }

        public override void BuyMemory()
        {
            Console.WriteLine("金士顿 骇客神条 8g");

        }

        public override void BuyGraphicsCard()
        {
            Console.WriteLine("GTX 1050");
        }

        public override void BuyBoard()
        {
            Console.WriteLine("B85M DS3H");

        }
    }
}
