using System;
using CommandPattern.RealWord;
using CommandPattern.RealWord.Commands;

namespace CommandPattern
{
    class Program
    {
        /*
         * 命令模式： 将一个请求封装为一个对象，从而使你可用不同的请求对客户（客户程序，也是行为的请求者）进行参数化；对请求排队或记录请求日志，以及支持可撤销的操作。——《设计模式》GoF
         * 
         * 使用频率：★★★★☆
         * 
         * 模式的组成：
    
            （1）、客户角色（Client）：创建具体的命令对象，并且设置命令对象的接收者。注意这个不是我们常规意义上的客户端，而是在组装命令对象和接收者，或许，把这个Client称为装配者会更好理解，因为真正使用命令的客户端是从Invoker来触发执行。
             这里暂时没有，是我们手动创建的

            （2）、命令角色（Command）：声明了一个给所有具体命令类实现的抽象接口。
                如：[Command]

            （3）、具体命令角色（ConcreteCommand）：命令接口实现对象，是“虚”的实现；通常会持有接收者，并调用接收者的功能来完成命令要执行的操作。
                如：[AttackCommand,RetreatCommand]

            （4）、请求者角色（Invoker）：要求命令对象执行请求，通常会持有命令对象，可以持有很多的命令对象。这个是客户端真正触发命令并要求命令执行相应操作的地方，也就是说相当于使用命令对象的入口。
                如：[Commander]

            （5）、接受者角色（Receiver）：接收者，真正执行命令的对象。任何类都可能成为一个接收者，只要它能够实现命令要求实现的相应功能。
                如：[Soldier]

         */
        static void Main(string[] args)
        {

            Soldier soldier = new Soldier();

            //1.司令员决定，策划两个命令
            Command command1 = new AttackCommand("进攻敌人左侧城楼", soldier);
            Command command2 = new RetreatCommand("撤退到根据地", soldier);

            
            Commander commander = new Commander();
            Console.WriteLine("===============下发命令1===============");
            //下发命令1
            commander.Command = command1;
            commander.SendCommand();

            Console.WriteLine("===============下发命令2===============");
            //下发命令2
            commander.Command = command2;
            commander.SendCommand();

            Console.ReadKey();

            /*
             * 总结：
             * 1.命令模式把命令的发出者和命令的执行者分开了，单独来用一个命令来保证两者的关系。
             * 2.Commander也可以持有多个命令，如果是一系列的队列命令，我们就可以一直的发命令可以对命令进行管理，比如撤销，恢复什么的。
             * 
             */
        }
    }
}
