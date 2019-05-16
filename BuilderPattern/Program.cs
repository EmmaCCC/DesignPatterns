using BuilderPattern.RealWord;
using System;

namespace BuilderPattern
{
    class Program
    {

        /*
        *  建造者模式：将一个复杂对象的构建与其表示相分离，使得同样的构建过程可以创建不同的表示。                   ——《设计模式》GoF
        *  
        * 
            模式的组成：

            （1）抽象建造者角色（Builder）：为创建一个Product对象的各个部件指定抽象接口，以规范产品对象的各个组成成分的建造。一般而言，此角色规定要实现复杂对象的哪些部分的创建，并不涉及具体的对象部件的创建。
            如：[IComputerBuilder]

            （2）具体建造者（ConcreteBuilder）

                1）实现Builder的接口以构造和装配该产品的各个部件。即实现抽象建造者角色Builder的方法。

                2）定义并明确它所创建的表示，即针对不同的商业逻辑，具体化复杂对象的各部分的创建

                3) 提供一个检索产品的接口

                4) 构造一个使用Builder接口的对象即在指导者的调用下创建产品实例

            如：[ProfessionalDIYerComputerBuilder,XiaoBaiDIYerComputerBuilder]


            （3）指导者（Director）：调用具体建造者角色以创建产品对象的各个部分。指导者并没有涉及具体产品类的信息，真正拥有具体产品的信息是具体建造者对象。它只负责保证对象各部分完整创建或按某种顺序创建。
            如：[Director]
                

            （4）产品角色（Product）：建造中的复杂对象。它要包含那些定义组件的类，包括将这些组件装配成产品的接口。
            如：[Computer]
             
       */
        static void Main(string[] args)
        {

           


            Director director = new Director();

            Console.WriteLine("===============专业DIY组装者===============");
            //专业DIY组装者
            IComputerBuilder computerBuilder1 = new ProfessionalDIYerComputerBuilder();

            //那也得按一定说明书组装电脑
            Computer computer1 = director.Guide(computerBuilder1);

            //这里是简化后的模式，可以自己手动组装，不再有Director这个角色，开发人员自己主动控制
            //Computer computer1 = computerBuilder1
            //     .UseCpu()
            //     .UseMemory()
            //     .UseGraphics().Build();

            //显示信息
            computer1.DisplayInfo();

            Console.WriteLine("===============小白IY组装者===============");

            //小白IY组装者
            IComputerBuilder computerBuilder2 = new XiaoBaiDIYerComputerBuilder();

            //Computer computer2 = computerBuilder2
            //     .UseCpu()
            //     .UseMemory()
            //     .UseGraphics().Build();

            Computer computer2 = director.Guide(computerBuilder2);

            computer2.DisplayInfo();
            Console.ReadKey();


            /*
           * 总结：
           * 1.建造者模式中的建造过程和步骤时固定的
           * 2.获得的产品的也是一样，不同的原料生产出不同的特点的产品。

           * 中心思想：当我们的一个对象的含有多个固定的步骤（组件）时，具体的步骤内容（组件的特性）可以一直在变化时，就可以使用建造者模式

           */

            /*

                .NET 中建造者模式的实现

               System.Text.StringBuilder 其实 就是一个建造者模式的实现，
               从名称也可以看出来。不过它的实现属于建造者模式的演化，此时的建造者模式没有指挥者角色和抽象建造者角色，StringBuilder类即扮演着具体建造者的角色，
               也同时扮演了指挥者和抽象建造者的角色，StringBuilder类扮演着建造string对象的具体建造者角色，其中的ToString()方法用来返回具体产品给客户端
               （相当于上面代码中GetProduct方法）。其中Append方法用来创建产品的组件(相当于上面代码中UseCpu()和UseMemory()方法)，
               因为string对象中每个组件都是字符，所以也就不需要指挥者的角色的代码（指的是Director.Guide()方法,用来调用创建每个组件的方法来完成整个产品的组装），
               因为string字符串对象中每个组件都是一样的,都是字符,所以Append方法也充当了指挥者Director.Guide()方法的作用。
            */
        }
    }
}
