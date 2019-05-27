using StragetyPattern.RealWord;
using System;

namespace StragetyPattern
{
    class Program
    {
        /*
         * 策略模式: 定义一系列算法，把它们一个个封装起来，并且使它们可互相替换。该模式使得算法可独立于使用它的客户而变化。 ——《设计模式》GoF　　　　　　  
         * 
         * 使用频率：★★★★☆
         * 
         * 模式的组成：

            （1）环境角色（Context）：持有一个Strategy类的引用。

                    需要使用ConcreteStrategy提供的算法。

                    内部维护一个Strategy的实例。

                    负责动态设置运行时Strategy具体的实现算法。

                    负责跟Strategy之间的交互和数据传递  如：[Navigator]

            （2）抽象策略角色（Strategy）：定义了一个公共接口，各种不同的算法以不同的方式实现这个接口，
                Context使用这个接口调用不同的算法，一般使用接口或抽象类实现。  如：[IRouter]

            （3）具体策略角色（ConcreteStrategy）：实现了Strategy定义的接口，提供具体的算法实现。 如：[DistanceShortestRouter,LightLeastRouter,FeeLeastRouter]
         */
        static void Main(string[] args)
        {
          
            /*
             * 现实世界的例子：假设我们从郑州想去北京，打开高德地图一导航，有三条路线，我们分别展示三条路线策略的详情说明。
             */

            //使用距离最短策略
            Navigator navigator1 = new Navigator("郑州", "北京", new DistanceShortestRouter());
            navigator1.DisplayRoute();

            Console.WriteLine("==============================");

            //使用红绿灯最少策略
            Navigator navigator2 = new Navigator("郑州", "北京", new LightLeastRouter());
            navigator2.DisplayRoute();

            Console.WriteLine("==============================");

            //使用收费最少策略
            Navigator navigator3 = new Navigator("郑州", "北京", new FeeLeastRouter());
            navigator3.DisplayRoute();

            Console.ReadKey();

            /*
              * 总结：
              * 1.这里我们定义了一系列的路线算法，然后用一个路线接口约束，这样的话使用不同的实现就可以互相替换了，使得算法可以独立于使用它的客户而变化。
              * 2.其实策略模式算是比较简单的一个模式，没有过多的嵌套和抽象，非常直观。

              * 中心思想：其实就是干一件事，有很多不同的方法，每个方法的侧重点也不一样，我自己可以考虑用那种方法。当我们遇到这种逻辑的时候就可以使用策略模式了。

          */
        }
    }
}
