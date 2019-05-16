using ProxyPattern.RealWord;
using ProxyPattern.RealWord2;
using System;

namespace ProxyPattern
{
    class Program
    {
        /*
         *  代理模式: 为其他对象提供一种代理以控制对这个对象的访问。——《设计模式》GoF
         *  
         *  模式的组成：

        （1）抽象主题角色（Subject）：声明了真实主题和代理主题的公共接口，这样一来在使用真实主题的任何地方都可以使用代理主题。

        （2）代理主题角色（Proxy）：代理主题角色内部含有对真实主题的引用，从而可以操作真实主题对象；代理主题角色负责在需要的时候创建真实主题对象；代理角色通常在将客户端调用传递到真实主题之前或之后，都要执行一些其他的操作，而不是单纯地将调用传递给真实主题对象。

        （3）真实主题角色（RealSubject）：定义了代理角色所代表的真实对象。

        */
        static void Main(string[] args)
        {


            //尝试用国内ip访问
            TheCreateWall wall1 = new TheCreateWall(new ChinaClient());
            wall1.Check();

            Console.WriteLine("==============================");

            //用代理ip访问
            TheCreateWall wall2 = new TheCreateWall(new ProxyClient());
            wall2.Check();

            Console.WriteLine("==============================");

            //改造：通过构造函数注入不同的ChinaClient，以便这个代理客户端能为多个人服务。
            TheCreateWall wall3 = new TheCreateWall(new ProxyClient(new ChinaClient()));
            wall3.Check();


            /*
             * 试想下面一个情况：东哥在美国干了一件大事，记者纷纷来访要问一问具体的情况，好做报道啊，但是东哥肯定不愿意说，
             * 但是得采访啊，索性东哥就委托经纪人先挡着，自己先藏起来
             *  
             */

            //采访刘强东,不出意外，肯定不说
            Reporter reporter = new Reporter();
            var star = new Star() { Name = "刘强东" };
            reporter.Interview(star, "请问刘强东先生，这次美国事件到底是什么情况?");

            //采访刘强东的经纪人
            reporter.Interview(new Broker(star), "请问刘强东的事是怎么了");

            Console.ReadKey();


            /*
             * 总结：
             * 1.代理对象和实际对象应该有共同的行为，不然的话不一样也是绕不过TheCreateWall的检查的，即实现接口或者抽象类。
             * 2.代理对象内部有一个真实对象的引用，可以向真实对象传递信息，也可以从真实对象获取信息。

             * 中心思想：当我们的真实对象做不了一件事，或者想隐藏自己的一些事情，但是外界的接口又不改变的情况下，我们需要模拟一个假的真实对象，在其中搞一些事情然后再做操作。

             */
        }
    }
}
