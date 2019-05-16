using System;
using FactoryMethodPattern.FactoryMethod;
using FactoryMethodPattern.FactoryMethod.FactoryProviders;
using FactoryMethodPattern.RealWord;
using FactoryMethodPattern.SimpleFactory;
using XiaoMiPhone = FactoryMethodPattern.SimpleFactory.XiaoMiPhone;

namespace FactoryMethodPattern
{
    class Program
    {
        /*
         * 工厂方法模式：定义一个用于创建对象的接口，让子类决定实例化哪一个类。Factory Method使得一个类的实例化延迟到子类。--《设计模式》GoF
         * 
         * 模式的组成：

          可以看出，在工厂方法模式的结构图有以下角色：

          （1）抽象工厂角色（Creator）: 充当抽象工厂角色，定义工厂类所具有的基本的操作，任何具体工厂都必须继承该抽象类。
           如：[XiaoMiPhoneFactoryProvider,IHttpHandlerFactory]

          （2）具体工厂角色（ConcreteCreator）：充当具体工厂角色，该类必须继承抽象工厂角色，实现抽象工厂定义的方法，用来创建具体产品。
          如：[XiaoMi8FactoryProvider,XiaoMi9FactoryProvider,AshxHttpHandlerFactory,AspxHttpHandlerFactory]

          （3）抽象产品角色（Product）：充当抽象产品角色，定义了产品类型所有具有的基本操作，具体产品必须继承该抽象类。
          如：[XiaoMiPhone,IHttpHandler]

          （4）具体产品角色（ConcreteProduct）：充当具体产品角色，实现抽象产品类对定义的抽象方法，由具体工厂类创建，它们之间有一一对应的关系。
          如：[XIaoMi8,XIaoMi9]

         */
        static void Main(string[] args)
        {
            /*
             * 这里我们引入简单工厂模式来对比，进而引入工厂方法模式。
             */

            /*
             * 1.简单工厂模式：
             * 业务场景：小米手机工厂生产手机，并获取手机信息
            */


            /*
             * 1.某个业务点需要一个XiaoMiPhone对象，我们通过当前传入的类型，分别产生具体的小米手机
             * 2.这样的话这个业务点以后有新的手机类型也不用变化，我们把变化全部挪到了XiaoMiPhoneFactory.GetPhone
             * 3.这样使用简单工厂模式 稍微削弱了耦合度
            */
            //某个业务点需要一个XiaoMiPhone对象，我们通过当前传入的类型，分别产生具体的小米手机

            Console.WriteLine("==============XiaoMi8=============");
            SimpleFactory.XiaoMiPhone phone1 = SimpleFactory.XiaoMiPhoneFactory.GetPhone(PhoneType.XiaoMi8);
            Console.WriteLine(phone1.GetPhoneInfo());

            Console.WriteLine("==============XiaoMi9=============");
            SimpleFactory.XiaoMiPhone phone2 = SimpleFactory.XiaoMiPhoneFactory.GetPhone(PhoneType.XiaoMi9);
            Console.WriteLine(phone2.GetPhoneInfo());

            /*
             * 简单工厂的问题：倘若我们要加一个手机类型，我们需要在PhoneType里边加一个，并要修改XiaoMiPhoneFactory.GetPhone中的switch代码，以适配新的手机类型。
             * 我们的原则是 对修改关闭，对扩展开放，我们期望努力接近这个原则，尽最大努力在修改需求的时候只扩展代码（添加新代码，原来代码不变），不修改原来代码。
             * 所以简单工厂模式改进成了工厂方法模式(FactoryMethod)。
             * 
             * 2.工厂方法模式：小米公司生产小米手机，需要一个小米手机工厂来生产
             */


            //初始化小米公司，默认有一个Mix2的工厂，生产Mix2手机
            Console.WriteLine("==============Mix2的工厂，生产Mix2手机=============");
            XiaoMiCompany company = new XiaoMiCompany();

            company.DisplayPhoneInfo();

            Console.WriteLine("==============换成XiaoMi8的工厂，生产Mi8手机=============");

            company.SetXiaoMiPhoneFactoryProvider(new XiaoMi8FactoryProvider());
            company.DisplayPhoneInfo();

            Console.WriteLine("==============换成XiaoMi9的工厂，生产Mi9手机=============");

            company.SetXiaoMiPhoneFactoryProvider(new XiaoMi9FactoryProvider());
            company.DisplayPhoneInfo();

            /*
             * 总结：
             * 1.这里我们不必改原来的代码，这里代码逻辑可能简单，可能看不出来效果，但是业务一旦复杂就体现出来了。
             * 但是这里我们一旦有新的手机型号是，我们只需要再加一个FactoryProvider就行了，不必像简单工厂那样还要改一下swtich(type)
             * 还要在PhoneType里边加一个类型了。
             * 
             * 2.假如XiaoMiCompany已经是你写好了一个类了，你供给外部使用，但是一旦有需要，外部就不能像简单工厂那样改你的代码来增加实现吧
             * 所以如果你这时候设计成 工厂方法模式时，对方就可以自己在外部加一个新的Provider，然后替换掉你那个就可以了，你的代码完全不用动，还能对外扩展
             * 这就更进一步的实现了 对扩展开发 对修改关闭的原则，可以看出，工厂方法模式比简单工厂模式更具备扩展性。
             * 
             * 3.工厂方法模式是一种非常常用的设计模式，.Net 的类库 或者 各种框架的设计中都用了这种模式，试想一下，你在使用这些类库和
             * 框架的时候，不能修改人家的代码吧，但是你会发现，你用框架的时候扩展性都很强，可以随时替换一些配置来满足你的要求。
             */


            /*
             * 这里我们模拟asp.net Http请求的处理，一个请求过来，我们根据不同的后缀名我们会返回不同的响应结果。
             * 
             */

            Console.WriteLine("==============模拟Http请求管道=============");
            //1.模拟一个请求
            HttpContext context = new HttpContext();
            context.Request = "http://localhost/user/login.aspx";

            //2.进入管道进行处理
            RequestPipeline pipeline = new RequestPipeline(context);
            pipeline.GetProcessResult();

            //如果换成ashx请求

            HttpContext context2 = new HttpContext();
            context2.Request = "http://localhost/user/login.ashx";

            //2.进入管道进行处理
            RequestPipeline pipeline2 = new RequestPipeline(context2);
            pipeline2.GetProcessResult();

            //如果我们想处理别的请求
            //用pipeline2.RegisterIHttpHandlerFactory() 注册其他的工厂

            /*
             * 1.有了这个架构，我们就可以直接再添加处理静态文件的工厂StaticFileHttpHandlerFactory和StaticHttpHandler
             * 2.甚至后来的MvcHttpHandlerFactory和MvcHttpHandler 也能这样的扩展
             * 3.此时此刻可能你才觉得这样设计的重要性，因为我们经常没这么想过以后的或者没有写框架给人用，反正都是自己用，
             *   不满足需求就直接一把梭改源代码的，改来改去就改不下去了。
             *  
             * 中心思想：一般能使用简单工厂的地方都可以替换为工厂方法模式，工厂方法模式只是简单工厂好一点，可以用依赖入住来解耦，只要是工厂模式都差不多，只是作了扩展优化，看情况而定。
             */
            Console.ReadKey();
        }
    }
}
