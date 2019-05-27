using System;
using System.Text;
using IteratorPattern.RealWord;
using IteratorPattern.RealWord2;

namespace IteratorPattern
{
    class Program
    {
        /*
         * 迭代器模式：提供一种方法顺序访问一个聚合对象中的各个元素，而又不暴露该对象的内部表示。 ——《设计模式》GoF
         * 
         * 使用频率：★★★★★
         * 
         * 模式的组成：
    
            从迭代器模式的结构图可以看出，它涉及到四个角色，它们分别是：

            （1）抽象迭代器(Iterator)：抽象迭代器定义了访问和遍历元素的接口，一般声明如下方法：用于获取第一个元素的first()，用于访问下一个元素的next()，用于判断是否还有下一个元素的hasNext()，用于获取当前元素的currentItem()，在其子类中将实现这些方法。
                如：[IIterator]

            （2）具体迭代器(ConcreteIterator)：具体迭代器实现了抽象迭代器接口，完成对集合对象的遍历，同时在对聚合进行遍历时跟踪其当前位置。
                如：[StringToCharIterator,LowerFirstIterator,UpperFirstIterator,UpperAndLowerIterator]

            （3）抽象聚合类(Aggregate)：抽象聚合类用于存储对象，并定义创建相应迭代器对象的接口，声明一个createIterator()方法用于创建一个迭代器对象。
                如：[IIteratorable]

            （4）具体聚合类(ConcreteAggregate)：具体聚合类实现了创建相应迭代器的接口，实现了在抽象聚合类中声明的createIterator()方法，并返回一个与该具体聚合相对应的具体迭代器ConcreteIterator实例。
                如：[MyString,Alphabet]
                
        */
        static void Main(string[] args)
        {
            //1.构造一个字符串，迭代里边的字符
            var str = new MyString("heowfhas,123");
            IIteratorable iteratorable = str;

            var iterator = iteratorable.GetIterator();
            while (iterator.MoveNext())
            {
                var current = iterator.GetCurrent();
                Console.WriteLine(current);
            }
            Console.ReadKey();


            //2.这里我们对字母表进行遍历迭代，并且使用不同的迭代器
            var alphabet = new Alphabet();

            IIteratorable iteratorable2 = alphabet;

            //使用 小写优先展示 迭代器
            //alphabet.SetIterator(new LowerFirstIterator(alphabet));

            //使用 大写优先展示 迭代器
            //alphabet.SetIterator(new UpperFirstIterator(alphabet));

            //使用 大小写合并迭代器 迭代器
            alphabet.SetIterator(new UpperAndLowerIterator(alphabet));


            var iterator2 = iteratorable2.GetIterator();
            while (iterator2.MoveNext())
            {
                var current = iterator.GetCurrent();
                Console.Write(current+",");
            }
            Console.ReadKey();

            /*
            * 总结：
            * 1.迭代器模式是为了来遍历一些对象来设计了接口。
            * 2.c#中已经提供了IEnumerable这个接口，就是迭代器模式的具体实现，如要用可以直接继承实现它。

            * 中心思想：迭代器模式是一种简单的模式，实际上就是遍历的一种算法，当然你也可以自己实现一套算法，这个模式不用太介意，框架里边一般都有这个模式的实现，也没多大难度 。

        */
        }
    }
}
