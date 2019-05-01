using AdapterPattern.RealWord;
using AdapterPattern.RealWord2;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Comment()
        {
            /*
             * 适配器模式: 将一个类的接口转换成客户希望的另一个接口。Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。--《设计模式》Gof
             * 
             * 模式的组成

             （1）目标角色（Target）：定义Client使用的与特定领域相关的接口。如： [IHDMIInterfaceTarget,ICanSayEnglish]

             （2）客户角色（Client）：与符合Target接口的对象协同。 如： [GraphicsCard,English]，可有可无

             （3）被适配角色（Adaptee)：定义一个已经存在并已经使用的接口，这个接口需要适配。如： [VGAInterface,Chinese]

             （4）适配器角色（Adapter) ：适配器模式的核心。它将对被适配Adaptee角色已有的接口转换为目标角色Target匹配的接口。对Adaptee的接口与Target接口进行适配。

              如： [VGAToHDMIAdapter,Translator]
            */

        }
        static void Main(string[] args)
        {
            //买了新显卡，先显卡需要一个IHDMIInterfaceTarget的接口实现，即能输出HDMI信号的口
            //但是电脑只有VGA的口，又不想扔掉，于是买了一个转接适配器，把VGA的口接到适配器上
            var adapter = new VGAToHDMIAdapter(new VGAInterface());

            //于是乎，我们就有了一个IHDMIInterfaceTarget的口（因为适配器肯定实现了IHDMIInterfaceTarget的接口功能）就可以接入了
            IHDMIInterfaceTarget hdmiTarget = adapter;

            //显示一下接受到的HDMI信号
            hdmiTarget.DisplayHDMISignal();
            
            Console.WriteLine("==============================");

            //当然，如果你有钱可以重新买一个HDMI的接口线
            IHDMIInterfaceTarget hdmiTarget2 = new HDMIInterface();
            hdmiTarget2.DisplayHDMISignal();

            Console.WriteLine("==============================");
            //新显卡急需一个IHDMIInterfaceTarget标准的对象才能工作
            GraphicsCard graphics = new GraphicsCard();
            //用适配器的做的 和 真正的hdmi接口的 都可以
            graphics.Work(adapter);
            graphics.Work(hdmiTarget2);

            Console.WriteLine("==============================");


            /*
             * 看一个中国人，英国人和翻译官的例子
             * 中国人(Adaptee)要和英国人（Client）交流，但是中国人说的话英国人听不懂，需要一个翻译官（Adapter）来翻译成听的懂的英文或能说英语的人（Target）
              
             */

            //不经过翻译官，直接问
            var chinese = new Chinese("你好,早饭吃了吗");
            var english = new English();
            english.Answer(chinese.Hello);

            Console.WriteLine("==============================");
            //翻译官来帮助 一下
            ICanSayEnglish translator = new Translator(new Chinese("你好,早饭吃了吗"));
            //翻译出来英文的hello
            var englishHello = translator.SayEnglish();
            english.Answer(englishHello);

            Console.ReadKey();

            /*
            * 总结：
            * 1.目标对象 IHDMIInterfaceTarget，被适配者VGAToHDMIAdapter，适配器 VGAToHDMIAdapter。
            * 2.适配器拥有目标对象的操作，并且接受被适配者，内部处理两者的适配关系。
            * 3.适配器模式和代理模式的区别是：代理模式是中间对象和原对象有相同的操作，适配器模式是中间对象和目标对象有相同的操作。


            * 中心思想：当我们有一个老的功能，要接入一个新的功能时，我们又不想把老的功能去掉或者是还需要用到老的功能，但是和新功能接口又不匹配，我们就可以
            * 引入一个中间适配器去处理一下，达到老功能能用，新接口又不损坏。

            */

        }
    }
}
