using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.Soups
{
    public class DuSiTang : Soup
    {
        public override int Price => 10;

        public override void Cook()
        {
            Console.WriteLine("酸辣肚丝汤：美味可口");
        }
    }
}
