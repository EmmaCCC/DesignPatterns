using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.VegetableDishs
{
    public class TuDouSi : VegetableDish
    {
        public override int Price => 5;

        public override void Cook()
        {
            Console.WriteLine("土豆丝：清炒土豆丝");
        }
    }
}
