using System;
using System.Collections.Generic;
using System.Text;
namespace StragetyPattern.Offical
{

    /// <summary>
    /// MainApp startup class for Structural
    /// Proxy Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainAppTest()
        {
            // Create proxy and request a service
            /*
             * 这里的Proxy相当于我们的ProxyClient
             * 下边是我们的对象的统一访问接口，相当于我们的IClient
             *  abstract class Subject 
                {
                    public abstract void Request();
                }

               这是我们的真实对象，相当ChinaClient
             class RealSubject : Subject
                {
                    public override void Request()
                    {
                        Console.WriteLine("Called RealSubject.Request()");
                    }
                }

             这里操作没有TheCreateWall那一步，但是是一样的效果。
             */
            Proxy proxy = new Proxy();
            proxy.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Subject
    {
        public abstract void Request();
    }
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
    /// <summary>
    /// The 'Proxy' class
    /// </summary>
    class Proxy : Subject
    {
        private RealSubject _realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }

}
