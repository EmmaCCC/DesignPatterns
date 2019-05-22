using System;
using MediatorPattern.RealWord;

namespace MediatorPattern
{
    class Program
    {
        /*
         * 中介者模式：定义了一个中介对象来封装一系列对象之间的交互关系。中介者使各个对象之间不需要显式地相互引用，从而使耦合性降低，而且可以独立地改变它们之间的交互行为。——《设计模式》GoF
         * 
         * 模式的组成：
    
            （1）抽象中介者角色（Mediator）：在里面定义各个同事之间交互需要的方法，可以是公共的通信方法，也可以是小范围的交互方法。
                如:[Mediator]
            （2）具体中介者角色（ConcreteMediator）：它需要了解并维护各个同事对象，并负责具体的协调各同事对象的交互关系。
                如:[LianJiaMediator]
            （3）抽象同事类（Colleague）：通常为抽象类，主要约束同事对象的类型，并实现一些具体同事类之间的公共功能，比如，每个具体同事类都应该知道中介者对象，也就是具体同事类都会持有中介者对象，都可以到这个类里面。
                如:[Person]
            （4）具体同事类（ConcreteColleague）：实现自己的业务，需要与其他同事通信时候，就与持有的中介者通信，中介者会负责与其他同事类交互。
                如:[HouseOwner,Renter]

         */
        static void Main(string[] args)
        {
            LianJiaMediator mediator = new LianJiaMediator();

            HouseOwner houseOwner = new HouseOwner("张三", mediator);
            Renter renter = new Renter("李四", mediator);

            //中介应该都知道房东和租客
            mediator.HouseOwner = houseOwner;
            mediator.Renter = renter;

            //房东发布消息
            Console.WriteLine("==============房东发布消息==============");
            houseOwner.SendMessage("租房，3室一厅，2500");

            //租客发布消息
            Console.WriteLine("==============租客发布消息==============");
            renter.SendMessage("2000租不租");

            Console.ReadKey();
        }
    }
}
