using System;
using DecoratorPattern.RealWord;
using DecoratorPattern.RealWord.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        /*
         * 装饰者模式：动态地给一个对象增加一些额外的职责。就增加功能而言，Decorator模式比生成子类更为灵活。——  《设计模式》GoF
         * 
         * 使用频率：★★★☆☆
         * 
         * 模式的组成：

　　        （1）抽象构件角色（Component）：给出一个抽象接口，以规范准备接收附加责任的对象。如：[Phone]

　　        （2）具体构件角色（Concrete Component）：定义一个将要接收附加责任的类。如：[XiaoMiPhone]

　　        （3）装饰角色（Decorator）：持有一个构件（Component）对象的实例，并实现一个与抽象构件接口一致的接口。

　　        （4）具体装饰角色（Concrete Decorator）：负责给构件对象添加上附加的责任。
         */
        static void Main(string[] args)
        {

            Phone phone = new XiaoMiPhone();

            //先添加一个贴膜
            Console.WriteLine("==============先添加一个贴膜==============");
            PhoneDecorator phoneWithSticker = new Sticker(phone);
            phoneWithSticker.Show();

            //再添加一个挂件
            Console.WriteLine("==============再添加一个挂件==============");
            PhoneDecorator phoneWithAccessory = new Accessory(phoneWithSticker);
            phoneWithAccessory.Show();

            //再添加一个护套
            Console.WriteLine("==============再添加一个护套==============");
            PhoneDecorator phoneWithCover = new Cover(phoneWithAccessory);
            phoneWithCover.Show();

            Console.ReadKey();

            /*
             * 总结：
             * 1.为了避免子类的爆炸产生，装饰者模式把子类统一，然后用为其他对象添加功能的方式产生新的对象和功能，减少了子类的产生。
             * 2.能够应对各种不同的装饰品的变化和添加，也能够很好地装饰出不同的产品。
             * 
             * 中心思想：要获取一系列对象，这些对象都是在原有对象上添加，修补出来的，而且这些功能还可能交替叠加变换，这时我们可以考虑装饰者模式。
             */
        }
    }
}
