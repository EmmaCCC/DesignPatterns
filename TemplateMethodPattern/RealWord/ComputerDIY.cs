using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern.RealWord
{
    public abstract class ComputerDIY
    {
        public void Display()
        {
            BuyCpu();
            BuyMemory();
            BuyGraphicsCard();
            BuyBoard();
        }


        public abstract void BuyCpu();
        public abstract void BuyMemory();
        public abstract void BuyGraphicsCard();
        public abstract void BuyBoard();
    }
}
