using ProxyPattern.RealWord;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 代理模式: 为其他对象提供一种代理以控制对这个对象的访问。——《设计模式》GoF
             

             * 总结：
             * 1.代理对象和实际对象应该有共同的行为，不然的话不一样也是绕不过TheCreateWall的检查的
             * 2.代理对象内部有一个真实对象的引用，可以向真实对象传递信息，也可以从真实对象获取信息。

             * 中心思想：当我们的真实对象做不了一件事，或者想隐藏自己的一些事情，但是外界的接口又不改变的情况下，我们需要模拟一个假的真实对象，在其中搞一些事情然后再做操作。

             */

            //尝试用国内ip访问
            TheCreateWall wall1 = new TheCreateWall(new ChinaClient());
            wall1.Check();

            Console.WriteLine("==============================");

            //用代理ip访问
            TheCreateWall wall2 = new TheCreateWall(new ProxyClient());
            wall2.Check();


            //改造：通过构造函数注入不同的ChinaClient，以便这个代理客户端能为多个人服务。
            TheCreateWall wall3 = new TheCreateWall(new ProxyClient(new ChinaClient()));
            wall3.Check();

            Console.ReadKey();
        }
    }
}
