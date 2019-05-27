using FacadePattern.RealWord;
using System;

namespace FacadePattern
{
    class Program
    {
        /*
         * 外观模式：为子系统中的一组接口提供一个一致的界面，Facade模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。——《设计模式》GoF
         * 
         * 使用频率：★★★★★
         * 
         * 模式的组成：

            （1）外观角色（Facade）：在客户端可以调用它的方法，在外观角色中可以知道相关的（一个或者多个）子系统的功能和责任；在正常情况下，它将所有从客户端发来的请求委派到相应的子系统去，传递给相应的子系统对象处理。
                如:[IntelligentHomeSystem]
            （2）子系统角色（SubSystem）：在软件系统中可以有一个或者多个子系统角色，每一个子系统可以不是一个单独的类，而是一个类的集合，它实现子系统的功能；每一个子系统都可以被客户端直接调用，或者被外观角色调用，它处理由外观类传过来的请求；子系统并不知道外观的存在，对于子系统而言，外观角色仅仅是另外一个客户端而已。
                如:[IntelligentAirCondiction,IntelligentLight,IntelligentTv]

         */
        static void Main(string[] args)
        {

            IntelligentHomeSystem homeSystem = new IntelligentHomeSystem();

            Console.WriteLine("==============开启回家模式==============");
            homeSystem.GoHomeMode();

            Console.WriteLine("==============开启离家模式==============");
            homeSystem.LeaveHomeMode();

            Console.ReadKey();

            /*
             * 总结：
             * 1.这个模式没什么好说，就是简单的封装调用，从某种角度来说可能不算一种模式。
             * 
             * 中心思想：一个业务要调用多个子功能的时候，可以再封装一下，统一成一个接口。
             * 
             */
        }
    }
}
