using System;
using StatePattern.RealWord;
using StatePattern.RealWord2;

namespace StatePattern
{
    class Program
    {
        /*
         * 状态模式：允许一个对象在其内部状态改变时改变它的行为。从而使对象看起来似乎修改了其行为。——《设计模式》GoF
         * 
         * 使用频率：★★★☆☆
         * 
         * 模式的组成：
    
            （1）、环境角色（Context）：也称上下文，定义客户端所感兴趣的接口，并且保留一个具体状态类的实例。这个具体状态类的实例给出此环境对象的现有状态。
                如：[Account,SpeedSwitch]
 
            （2）、抽象状态角色（State）：定义一个接口，用以封装环境对象的一个特定的状态所对应的行为。 
                如：[AccountState,SwitchState]

            （3）、具体状态角色（ConcreteState）：每一个具体状态类都实现了环境（Context）的一个状态所对应的行为。
                如：[BronzeVipState,HighLevel]

         */
        static void Main(string[] args)
        {
            //1.状态模式场景1，有问题
            Account account = new Account();
            Console.WriteLine("===============初识状态===============");
            account.Display();
            Console.WriteLine("===============加存200===============");

            account.Save(200);

            account.Display();
            Console.WriteLine("===============加存500===============");

            account.Save(500);
            account.Display();

            Console.WriteLine("===============消费650（预期直接从黄金变青铜）===============");

            account.Consume(650);
            account.Display();
            Console.WriteLine("===============存1000（预期直接从青铜变黄金）===============");
            account.Save(1000);
            account.Display();

            //场景2

            SpeedSwitch speedSwitch = new SpeedSwitch();

            Console.WriteLine("===============下级===============");
            speedSwitch.Next();
            speedSwitch.Display();

            Console.WriteLine("===============下级===============");
            speedSwitch.Next();
            speedSwitch.Display();

            Console.WriteLine("===============下级===============");
            speedSwitch.Next();
            speedSwitch.Display();

            Console.WriteLine("===============下级===============");
            speedSwitch.Next();
            speedSwitch.Display();

            /*
             * 总结：
             * 1.可以看出状态模式场景1中 各状态之间不能跨状态跳转，因为余额可能一下就能从青铜级别跳到黄金级别，然而在青铜级别下，我们判断了能到白银级别。
             * 2.状态模式只能用于状态不可跨越，且上一个状态经过变换之后只能到唯一的下一状态。这样我们才能准确的使用状态模式，比如红绿灯的状态变换：绿-黄-红-绿-黄..
             * 3.环境类实际上就是拥有状态的对象，环境类有时候可以充当状态管理器(State Manager)的角色，可以在环境类中对状态进行切换操作。
             */


            Console.ReadKey();
        }

    }


}
