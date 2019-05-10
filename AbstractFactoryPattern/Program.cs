using AbstractFactoryPattern.RealWord;
using AbstractFactoryPattern.RealWord.MealFactorys;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        /*
         * 提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。——《设计模式》GoF
         * 
         * 模式的组成

          （1）抽象产品类角色（AbstractProduct）：为抽象工厂中相互依赖的每种产品定义抽象接口对象，也可以这样说，有几种产品，就要声明几个抽象角色，每一个抽象产品角色和一种具体的产品相匹配。

          （2）具体产品类（ConcreteProduct）：具体产品类实现了抽象产品类，是针对某个具体产品的实现的类型。

          （3）抽象工厂类角色（Abstract Factory）：定义了创建一组相互依赖的产品对象的接口操作，每种操作和每种产品一一对应。

          （4）具体工厂类角色（ConcreteFactory）：实现抽象类里面的所有抽象接口操作，可以创建某系列具体的产品，这些具体的产品是“抽象产品类角色”的子类。
         */
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
             * 总结：
             * 1.不同的套餐工厂就可以生产不同的套餐，假如我们的大米套餐就包含这三样（一个素菜，一个荤菜，一个汤）
             * 2.这样我们以后还以增加各种不同的素菜，荤菜，汤类，然后再添加不同的工厂（比如：豪华套餐，超级至尊套餐等等，只需要生产不同菜就可以了）并不用修改原来的代码
             * 3.抽象工厂模式 要求生产出来的产品基本不变，每种产品的种类可以多种多样，如果要有新的产品，就要在工厂里边添加新的方法，就违背了原则。
             * 4.抽象工厂模式 只是 比工厂方法模式多生产了产品，工厂方法模式是生产一个产品，抽象工厂模式是生产一组产品。其他的完全一样。
             *   
             * 中心思想：当我们需要一组对象的产生时，并且这一组对象以后基本不会再变化，但是每种对象可能会有多种多样时，我们可以使用抽象工厂模式。
             */
            Console.ReadKey();
        }
    }
}
