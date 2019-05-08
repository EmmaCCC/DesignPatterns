using SingleInstancePattern.RealWord;
using System;
using System.Runtime.InteropServices;

namespace SingleInstancePattern
{
    class Program
    {

        /*
         * 保证一个类仅有一个实例，并提供一个该实例的全局访问点。　--《设计模式GoF》
         * 
         * 
         * 模式的组成

         （1）单件实例（Singleton）：这个模式里面只有一个类型，就是Singleton类型，并且这个类只有一个实例，可以通过Instance()方法获取该类型的实例。

         */

        static void Main(string[] args)
        {
            //第一种单例模式(传统单例模式)
            Console.WriteLine("========第一种单例模式(传统单例模式)=========");
            var singleton1 = Singleton.GetSingleton();
            var singleton2 = Singleton.GetSingleton();

            Console.WriteLine(singleton1.Id);
            Console.WriteLine(singleton2.Id);

            Console.WriteLine("========第二种单例模式（利用C#语言特性（CLR）实现的）=========");
            //第二种单例模式（利用C#语言特性（CLR）实现的）
            Console.WriteLine(Singleton2.Instance.Id);
            Console.WriteLine(Singleton2.Instance.Id);


            Console.WriteLine("========模拟HttpContext.Current=========");

            //模拟HttpContext.Current：这里HttpContext这是当前请求的单例，并不是全局的单例
            //当前请求任何时候任何地点访问都是同一个请求
         
            Console.WriteLine(HttpContext.Current.Request);
            Console.WriteLine(HttpContext.Current.Request);
            Console.ReadKey();

            /*
            * 总结：
            * 1.单例模式保证外界访问时只有一个实例
            * 2.当我们觉得某一个对象需要全局唯一时，或者我们需要减少对象new时的开销，只保证一个实例时，我们可以用单例模式。
            * 3.有些情况必须是单例，不然会出错。比如：HttpContext.Current;有些情况可以不是单例，但是多例的话会增加很多开销，就也实现成单例。
              比如：RedisClient，MongoDbClient等很多需要建立连接的对象建议设置成单例(当然这里也可以扩展的对象池里边，即很多个单例在一起)。

            * 中心思想：当我们觉得某一个对象需要全局唯一时，或者我们需要减少对象new时的开销，只保证一个实例时，我们可以用单例模式。
          
            */
        }
    }
}
