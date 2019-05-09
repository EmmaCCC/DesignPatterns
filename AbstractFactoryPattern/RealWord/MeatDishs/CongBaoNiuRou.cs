using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.MeatDishs
{
    public class CongBaoNiuRou : MeatDish
    {
        public override int Price => 25;

        public override void Cook()
        {
            Console.WriteLine("葱爆牛肉：上等精细牛肉加小香葱，大火爆炒");
        }
    }
}
