using System;
using TemplateMethodPattern.RealWord;

namespace TemplateMethodPattern
{
    class Program
    {
        /*
         * 模板方法模式：定义一个操作中的算法的骨架，而将一些步骤延迟到子类中。Template Method使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。——《设计模式》GoF
         * 
         * 模式的组成：

　　        （1）抽象类角色（AbstractClass）：定义一个模板方法（TemplateMethod），在该方法中包含着一个算法的骨架，具体的算法步骤是PrimitiveOperation1方法和PrimitiveOperation2方法，该抽象类的子类将重定义PrimitiveOperation1和PrimitiveOperation2操作。
                如:[ComputerDIY]

　　        （2）具体类角色（ConcreteClass）：实现PrimitiveOperation1方法和PrimitiveOperation2方法以完成算法中与特定子类（Client）相关的内容。
                如:[HighEquipmentComputer,LowEquipmentComputer]
　　
         */
        static void Main(string[] args)
        {
            Console.WriteLine("==============高端机配置================");
            ComputerDIY computer1 = new HighEquipmentComputer();
            computer1.Display();

            Console.WriteLine("==============低端机配置================");
            ComputerDIY computer2 = new LowEquipmentComputer();
            computer2.Display();

            Console.ReadKey();

            /*
             * 总结：
             * 1.这个模式比较简单，理解起来也比较容易，是最基本的面向对象和多肽的实现，没什么可说的。
             * 2.这个模式的实现也可以用其他的模式实现，都是相通的。
             * 
             * 
             * 中心思想：这个模式的关键在于 步骤是固定不变的，整体逻辑的流程和结构是不变，一般如果事先可以确定的话就可以用这个模式了。
             */
        }
    }
}
