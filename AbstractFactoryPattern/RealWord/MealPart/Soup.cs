using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.MealPart
{
    public abstract class Soup
    {
        public abstract int Price { get; }

        public abstract void Cook();
    }
}
