using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.VegetableDishs
{
    public class XiQinXiangGan : VegetableDish
    {
        public override int Price => 8;

        public override void Cook()
        {
            Console.WriteLine("西芹香干：小芹菜加五香豆干");
        }
    }
}
