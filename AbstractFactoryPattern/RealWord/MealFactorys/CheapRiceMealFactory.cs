using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.RealWord.MealPart;
using AbstractFactoryPattern.RealWord.MeatDishs;
using AbstractFactoryPattern.RealWord.Soups;
using AbstractFactoryPattern.RealWord.VegetableDishs;

namespace AbstractFactoryPattern.RealWord.MealFactorys
{
    public class CheapRiceMealFactory : RiceMealFactory
    {

        public override MeatDish GetMeatDish()
        {
            return new QingJiaoRouPian();
        }

        public override Soup GetSoup()
        {
            return new XiaoMiZhou();
        }

        public override VegetableDish GetVegetableDish()
        {
            return new TuDouSi();
        }
    }
}
