using ObserverPattern.RealWord;
using System;

namespace ObserverPattern
{
    /*
     *  定义对象间的一种一对多的依赖关系，以便当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并自动更新。——《设计模式》GoF
     * 
       观察者模式的结构图有以下角色：

    （1）抽象主题角色（Subject）：抽象主题把所有观察者对象的引用保存在一个列表中，并提供增加和删除观察者对象的操作，抽象主题角色又叫做抽象被观察者角色，一般由抽象类或接口实现。
        如：[IZhubo]

    （2）抽象观察者角色（Observer）：为所有具体观察者定义一个接口，在得到主题通知时更新自己，一般由抽象类或接口实现。
        如：[IObserver]

    （3）具体主题角色（ConcreteSubject）：实现抽象主题接口，具体主题角色又叫做具体被观察者角色。 如：[DouyuZhubo]

    （4）具体观察者角色（ConcreteObserver）：实现抽象观察者角色所要求的接口，以便使自身状态与主题的状态相协调。   如：[Observer]
         
     
     */


    class Program
    {
        static void Main(string[] args)
        {
            //没有抽象出来接口的时候
            IZhubo douyuZhubo = new DouyuZhubo("大司马");

            //添加关注的人
            douyuZhubo.AddObserver(new Observer("小明"));
            douyuZhubo.AddObserver(new Observer("小强"));
            douyuZhubo.AddObserver(new Observer("张三"));

            Console.WriteLine("==============================");

            //开始直播，所有关注者陆续收到通知
            douyuZhubo.Playing();

            Console.WriteLine("==============================");

            //小明取消关注了
            douyuZhubo.RemoveObserver(new Observer("小明"));
            //再次开始直播，小明不在收到直播通知
            douyuZhubo.Playing();

            Console.ReadKey();

            /*
               * 总结：
               * 1.观察者模式需要有一个发布消息的主题，主题内含有要通知的对象或者集合。
               * 2.一旦有新消息或者改变可以调用观察者（Observer）提前设定好的方法，并把一些信息传递过去。
               * 3.观察者模式还衍生出好多扩展，比如上边这个例子，观察者本身没法自己取消关注，还要依赖主播的添加和取消。

               * 中心思想：当我们遇到一些类似 A一旦怎么样，B就要怎么样的时候就可以用这个模式了，C#中的event其实就是观察者模式 。

           */
        }
    }
}
