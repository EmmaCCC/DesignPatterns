using System;
using BridgePattern.RealWord;
using BridgePattern.RealWord.Languages;
using BridgePattern.RealWord.OsPlatforms;

namespace BridgePattern
{
    class Program
    {
        /*
         * 桥接模式：将抽象部分与实现部分分离，使它们都可以独立地变化。-《设计模式》Gof
         * 
         * 模式的组成

           （1）抽象化角色(Abstraction)：抽象化给出的定义，并保存一个对实现化对象（Implementor）的引用。
                如：[DotNetLanguage]

           （2）修正抽象化角色(Refined Abstraction)：扩展抽象化角色，改变和修正父类对抽象化的定义。
                如：[CSharp,FSharp]

           （3）实现化角色(Implementor)：这个角色给出实现化角色的接口，但不给出具体的实现。必须指出的是，这个接口不一定和抽象化角色的接口定义相同，实际上，这两个接口可以非常不一样。实现化角色应当只给出底层操作，而抽象化角色应当只给出基于底层操作的更高一层的操作。
                如：[OSPlatformRunTime]

           （4）具体实现化角色(Concrete Implementor)：这个角色给出实现化角色接口的具体实现。
                如：[LinuxOSRunTime,WindowsOSRunTime,MacOSRunTime]
　　         
         */
        static void Main(string[] args)
        {
            DotNetLanguage dotNetLanguage = new CSharp();

            Console.WriteLine("=============C#在Linux平台运行===============");
            dotNetLanguage.SetOSPlatform(new LinuxOSRunTime());
            dotNetLanguage.Run();

            Console.WriteLine("=============C#在Windows平台运行===============");
            dotNetLanguage.SetOSPlatform(new WindowsOSRunTime());
            dotNetLanguage.Run();


            DotNetLanguage dotNetLanguage2 = new FSharp();

            Console.WriteLine("=============F#在Mac平台运行===============");
            dotNetLanguage2.SetOSPlatform(new MacOSRunTime());
            dotNetLanguage2.Run();

            Console.ReadKey();

            /*
             * 总结：
             * 1.在桥接模式中，两个类DotNetLanguage和OSPlatformRunTime分别定义了抽象与行为类型的接口，通过调用两接口的子类实现抽象与行为的动态组合。
             * 
             *  
             * 中心思想：遇见两组或者多组对象的不同实例的组合，通过桥梁可以实现各种动态的组合，这时我们可以使用桥接模式。
             */
        }
    }
}
