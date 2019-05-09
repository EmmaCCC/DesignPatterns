using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.Soups
{
    public class XiaoMiZhou : Soup
    {
        public override int Price => 2;

        public override void Cook()
        {
            Console.WriteLine("小米粥：没啥味");
        }
    }
}
