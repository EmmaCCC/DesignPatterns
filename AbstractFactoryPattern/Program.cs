using AbstractFactoryPattern.RealWord;
using AbstractFactoryPattern.RealWord.MealFactorys;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============便宜的套餐============");

            //便宜的套餐
            RiceMealFactory riceMealFactory = new CheapRiceMealFactory();
            riceMealFactory.Cook();

            Console.WriteLine("=============昂贵的套餐============");
            //昂贵的套餐
            RiceMealFactory riceMealFactory2 = new ExpensiveRiceMealFactory();
            riceMealFactory2.Cook();

            /*
             * 不同的套餐工厂就可以生产不同的套餐，假如我们的大米套餐就包含这三样（一个素菜，一个荤菜，一个汤）
             * 这样我们以后还以增加各种不同的素菜，荤菜，汤类，然后再添加不同的工厂（比如：豪华套餐，超级至尊套餐等等，只需要生产不同菜就可以了）并不用修改原来的代码
             * 
             */
            Console.ReadKey();
        }
    }
}
