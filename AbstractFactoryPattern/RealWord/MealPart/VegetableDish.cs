using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.MealPart
{
    /// <summary>
    /// 素菜
    /// </summary>
    public abstract class VegetableDish
    {
        public abstract int Price { get; }

        public abstract void Cook();
    }
}
