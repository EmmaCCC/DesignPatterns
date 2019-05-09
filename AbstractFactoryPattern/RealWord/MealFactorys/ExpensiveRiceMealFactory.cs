
using AbstractFactoryPattern.RealWord.MealPart;
using AbstractFactoryPattern.RealWord.MeatDishs;
using AbstractFactoryPattern.RealWord.Soups;
using AbstractFactoryPattern.RealWord.VegetableDishs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.RealWord.MealFactorys
{
  
    public class ExpensiveRiceMealFactory : RiceMealFactory
    {

        public override MeatDish GetMeatDish()
        {
            return new CongBaoNiuRou();
        }

        public override Soup GetSoup()
        {
            return new DuSiTang();
        }

        public override VegetableDish GetVegetableDish()
        {
            return new XiQinXiangGan();
        }
    }
}
