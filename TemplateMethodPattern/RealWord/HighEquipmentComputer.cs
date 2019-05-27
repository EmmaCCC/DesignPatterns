using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.RealWord
{
    public class HighEquipmentComputer: ComputerDIY
    {
        public override void BuyCpu()
        {
            Console.WriteLine("i9 9900K");
        }

        public override void BuyMemory()
        {
            Console.WriteLine("金士顿 骇客神条 32g");

        }

        public override void BuyGraphicsCard()
        {
            Console.WriteLine("RTX2080Ti");
        }

        public override void BuyBoard()
        {
            Console.WriteLine("ROG Z390 E GAMING");

        }
    }
}
