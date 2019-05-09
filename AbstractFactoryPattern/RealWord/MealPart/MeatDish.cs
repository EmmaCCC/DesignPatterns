using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.MealPart
{
    /// <summary>
    /// 荤菜
    /// </summary>
    public abstract class MeatDish
    {
        public abstract int Price { get; }
        /// <summary>
        /// 制作
        /// </summary>
        public abstract void Cook();
    }
}
