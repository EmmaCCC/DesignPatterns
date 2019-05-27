using System;
using FlyweightPattern.RealWord;

namespace FlyweightPattern
{
    class Program
    {
        /*
         * 享元模式：运用共享技术有效地支持大量细粒度的对象。——《设计模式》GoF
         * 
         * 使用频率：★☆☆☆☆
         * 
         * 模式的组成：
    
            （1）抽象享元角色（Flyweight）:此角色是所有的具体享元类的基类，为这些类规定出需要实现的公共接口。那些需要外部状态的操作可以通过调用方法以参数形式传入。
                如：[Character]

            （2）具体享元角色（ConcreteFlyweight）：实现抽象享元角色所规定的接口。如果有内部状态的话，可以在类内部定义。
                如：[CharacterA,CharacterB]

            （3）享元工厂角色（FlyweightFactory）：本角色负责创建和管理享元角色。本角色必须保证享元对象可以被系统适当地共享，当一个客户端对象调用一个享元对象的时候，享元工厂角色检查系统中是否已经有一个符合要求的享元对象，如果已经存在，享元工厂角色就提供已存在的享元对象，如果系统中没有一个符合的享元对象的话，享元工厂角色就应当创建一个合适的享元对象。
                如：[CharacterFactory]

            （4）客户端角色（Client）：本角色需要存储所有享元对象的外部状态。
                如：[color,pointSize等外部参数，也可以是其他类型]

         */
        static void Main(string[] args)
        {

            string doc = "ABAABB";

            CharacterFactory factory = new CharacterFactory();

            string[] colors = new string[] { "red", "blue" };

            int pointSize = 300;

            foreach (var ch in doc.ToCharArray())
            {
                pointSize++;
                var character = factory.GetCharacter(ch);
                character.Display(colors[pointSize % 2], pointSize);
            }

            Console.ReadKey();

            /*
             * 总结：
             * 1.享元模式，顾名思义，共享的元数据，这些东西是不变的，称为内部状态，然后用外部状态来区别不同的对象。
             * 
             * 中心思想：当出现有共享某些最基本最细粒度的对象时，我们可以用这个模式。
             */

        }
    }
}
