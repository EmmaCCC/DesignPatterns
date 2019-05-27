using ChainofResponsibilityPattern.RealWord;
using ChainofResponsibilityPattern.RealWord.Approvers;
using System;

namespace ChainofResponsibilityPattern
{
    class Program
    {
        /*
         * 责任链模式：避免请求发送者与接收者耦合在一起，让多个对象都有可能接受请求，将这些对象连接成一条链，并且沿着这条链传递请求，知道有对象处理它为止。——《设计模式》GoF
         * 
         * 使用频率：★★☆☆☆
         * 
         * 模式的组成：
    
          （1）抽象处理者角色（Handler）：抽象处理者定义了一个处理请求的接口，它一般设计为抽象类，由于不同的具体处理者处理请求的方式不同，因此在其中定义了抽象请求处理方法。因为每一个处理者的下家还是一个处理者，因此在抽象处理者中定义了一个自类型的对象，作为其对下家的引用。通过该引用，处理者可以连成一条链。

          （2）具体处理者角色（ConcreteHandler）：具体处理者是抽象处理者的子类，它可以处理用户请求，在具体处理者类中实现了抽象处理者中定义的抽象处理方法，在处理请求之前需要进行判断，看是否有相应的处理权限，如果可以处理请求就处理它，否则将请求转发给后继者；在具体处理者中可以访问链中下一个对象，以便请求的转发。
        */
        static void Main(string[] args)
        {
            /*
             * 场景：公司进行请假审批，不超过3天，经理可以直接审批通过，3-7天的需要总监审批，7天以上的需要老板审批，这是一个责任链模式的典型体现，
             * 因为审批这个过程可以说是所有人的责任，像一个链条一样传递下去。
             */

            //发起一个请假请求
            LeaveRequest leaveRequest = new LeaveRequest();
            leaveRequest.Day = 3;
          //leaveRequest.Day = 5;
          //leaveRequest.Day = 8;
            leaveRequest.Name = "大宋";

            //3个人，并设置这3个人的下一级审批人
            Manager manager = new Manager("张经理");
            Director director = new Director("刘总监");
            Boss boss = new Boss("李老板");
            manager.NextApprover = director;
            director.NextApprover = boss;

            //先从经理开始审批
            manager.ProcessLeaveRequest(leaveRequest);


            Console.ReadKey();
        }
    }
}
