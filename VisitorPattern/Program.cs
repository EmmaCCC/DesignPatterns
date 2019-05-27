using System;
using VisitorPattern.RealWord;
using VisitorPattern.RealWord.Medicines;
using VisitorPattern.RealWord.Visitors;

namespace VisitorPattern
{
    class Program
    {
        /*
         * 访问者模式：表示一个作用于某对象结构中的各个元素的操作。它可以在不改变各元素的类的前提下定义作用于这些元素的新的操作。——《设计模式》GoF
         * 
         * 模式的组成：
         * 
            （1）抽象访问者角色（Vistor）: 声明一个包括多个访问操作，多个操作针对多个具体节点角色（可以说有多少个具体节点角色就有多少访问操作），使得所有具体访问者必须实现的接口。
                如：[Visitor]

            （2）具体访问者角色（ConcreteVistor）：实现抽象访问者角色中所有声明的接口，也可以说是实现对每个具体节点角色的新的操作。
                如：[Charger,Fetcher]

            （3）抽象节点角色（Element）：声明一个接受操作，接受一个访问者对象作为参数，如果有其他参数，可以在这个“接受操作”里在定义相关的参数。
                如：[Medicine]

            （4）具体节点角色（ConcreteElement）：实现抽象元素所规定的接受操作。
                如：[XiaoYanMedicine,ZhiTengMedicine]

            （5）结构对象角色（ObjectStructure）：节点的容器，可以包含多个不同类或接口的容器。
                如：[Prescription]

         */
        static void Main(string[] args)
        {

            //医生开药单
            Prescription prescription = new Prescription();

            prescription.AddMedicine(new ZhiTengMedicine("止疼药1", 25));
            prescription.AddMedicine(new XiaoYanMedicine("消炎药1", 26));
            prescription.AddMedicine(new XiaoYanMedicine("消炎药2", 35));

            //两个访问者
            var visitor1 = new Charger();
            var visitor2 = new Fetcher();

            Console.WriteLine("===============划价员访问===============");
            prescription.AcceptVisitor(visitor1);

            Console.WriteLine("===============取药员访问===============");
            prescription.AcceptVisitor(visitor2);

            Console.ReadKey();

            /*
             * 总结：
             * 1.访问者模式中的元素的数据结构相对稳定，但是访问者可能是多个，而且访问者的操作可能不尽相同。
             * 2.访问者模式的核心是在于把不同的操作变成了不同的访问者，这样就可以扩展更多的操作和算法。
             * 
             * 中心思想：当一些对象的数据或特性相对稳定时，对该对象的操作可能五花八门各不一样，这时我们就可以用访问者模式。
             */
        }
    }
}
