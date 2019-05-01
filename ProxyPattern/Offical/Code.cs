using System;
using System.Collections.Generic;
using System.Text;
namespace StragetyPattern.Offical
{

    /*
       代理模式所涉及的角色有三个：

   （1）、抽象主题角色（Subject）：声明了真实主题和代理主题的公共接口，这样一来在使用真实主题的任何地方都可以使用代理主题。

   （2）、代理主题角色（Proxy）：代理主题角色内部含有对真实主题的引用，从而可以操作真实主题对象；代理主题角色负责在需要的时候创建真实主题对象；代理角色通常在将客户端调用传递到真实主题之前或之后，都要执行一些其他的操作，而不是单纯地将调用传递给真实主题对象。

   （3）、真实主题角色（RealSubject）：定义了代理角色所代表的真实对象。


   */


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
