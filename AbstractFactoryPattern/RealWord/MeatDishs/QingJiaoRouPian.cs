using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.MeatDishs
{
    public class QingJiaoRouPian : MeatDish
    {
        public override int Price => 15;

        public override void Cook()
        {
            Console.WriteLine("青椒肉片：肥肉皮加青椒爆炒");
        }
    }
}
