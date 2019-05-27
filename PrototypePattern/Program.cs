using System;
using PrototypePattern.RealWord;

namespace PrototypePattern
{
    class Program
    {
        /*
         * 使用原型实例指定创建对象的种类，然后通过拷贝这些原型来创建新的对象。--《设计模式》Gof
         * 
         * 使用频率：★★★☆☆
         * 
         * 模式的组成

            （1）原型类（Prototype）：原型类，声明一个Clone自身的接口； 如：[Prototype]

　          （2）具体原型类（ConcretePrototype）：实现一个Clone自身的操作。 如：[MonkeyKing]

　           在原型模式中，Prototype通常提供一个包含Clone方法的接口，具体的原型ConcretePrototype使用Clone方法完成对象的创建。
         * 
         */
        static void Main(string[] args)
        {

            Master master = new Master("唐僧");

            Prototype zhenshen = new MonkeyKing("孙悟空", master);

            var fenshen1 = zhenshen.Clone();
            fenshen1.Name = "分身1";

            var fenshen2 = zhenshen.Clone();
            fenshen2.Name = "分身2";

            Console.WriteLine($"真身:{zhenshen.Name}");
            Console.WriteLine($"分身:{fenshen1.Name}");
            Console.WriteLine($"分身:{fenshen2.Name}");

            Console.WriteLine($"真身和分身1的师傅:{((MonkeyKing) zhenshen).Master == (fenshen1 as MonkeyKing)?.Master}");
            Console.WriteLine($"真身和分身2的师傅:{((MonkeyKing) zhenshen).Master == (fenshen2 as MonkeyKing)?.Master}");

            Console.ReadKey();

            /*
             * 总结：
             * 1.原型模式其实就是克隆对象吧，节省对象的开销，别的没什么东西，之所以叫原型，是因为其他对象都是以这个为原型来的，好像有参照的味道一样。
             * 2.此例中的克隆是浅拷贝，即值类型复制过去，引用类型还是引用的同一个对象，所以分身的师傅们都是一样的。
             * 3.也可以作成深拷贝，所有的属性都不是同一个，这样克隆出来的对象还可以做稍微的修改而不影响本来对象。
             * 
             * 中心思想：当我们有需要大量的同类对象时，我们就可以用原型模式（暂且也叫克隆模式吧），这样克隆出来的对象的很多属性就不用自己一个一个复制了，还节省了开销。
             */
        }
    }
}
