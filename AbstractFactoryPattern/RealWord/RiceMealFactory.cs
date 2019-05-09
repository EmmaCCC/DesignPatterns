using AbstractFactoryPattern.RealWord.MealPart;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord
{
    public abstract class RiceMealFactory
    {
        public abstract MeatDish GetMeatDish();

        public abstract VegetableDish GetVegetableDish();

        public abstract Soup GetSoup();

        public void Cook()
        {
            var meat = this.GetMeatDish();
            var vegetable = this.GetVegetableDish();
            var soup = this.GetSoup();

            meat.Cook();
            vegetable.Cook();
            soup.Cook();
            Console.WriteLine($"总价：{meat.Price + vegetable.Price + soup.Price}");
        }
    }
}

