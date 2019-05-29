using InterpreterPattern.RealWord;
using System;

namespace InterpreterPattern
{
    class Program
    {
        /*
         * 解释器模式：给定一个语言，定义它的文法的一种表示，并定义一种解释器，这个解释器使用该表示来解释语言中的句子。——《设计模式》GoF
         * 
         * 使用频率：★☆☆☆☆
         * 
         * 模式的组成：
 
            （1）抽象表达式(AbstractExpression)：定义解释器的接口，约定解释器的解释操作。其中的Interpret接口，正如其名字那样，它是专门用来解释该解释器所要实现的功能。
                如：[Expression]

            （2）终结符表达式(Terminal Expression)：实现了抽象表达式角色所要求的接口，主要是一个interpret()方法；文法中的每一个终结符都有一个具体终结表达式与之相对应。比如有一个简单的公式R=R1+R2，在里面R1和R2就是终结符，对应的解析R1和R2的解释器就是终结符表达式。
                如：[ValueExpression]

            （3）非终结符表达式(Nonterminal Expression)：文法中的每一条规则都需要一个具体的非终结符表达式，非终结符表达式一般是文法中的运算符或者其他关键字，比如公式R=R1+R2中，“+”就是非终结符，解析“+”的解释器就是一个非终结符表达式。
                如：[AddExpression,SubExpression]

            （4）环境角色(Context)：这个角色的任务一般是用来存放文法中各个终结符所对应的具体值，比如R=R1+R2，我们给R1赋值100，给R2赋值200。这些信息需要存放到环境角色中，很多情况下我们使用Map来充当环境角色就足够了。
                如：[Calculator]

            （5）客户端（Client）：指的是使用解释器的客户端，通常在这里将按照语言的语法做的表达式转换成使用解释器对象描述的抽象语法树，然后调用解释操作。
                暂时没有体现
                 
         */
        static void Main(string[] args)
        {
            string statement = "71 + 32 - 5 + 10 - 12";
            Calculator calculator = new Calculator(statement);
            var result = calculator.Calc();
            Console.WriteLine($"{statement} = {result}");
            Console.ReadKey();

            /*
             * 总结：
             * 1.解释器模式给我们提供了一种解决问题的思路，把复杂的问题化归成最小的单元，然后然组合起来。
             * 2.解释器模式可扩展性比较强，解释的语法也比较简单，如果复杂的话就不适合使用这个模式。
             * 3.和组合模式有相似的地方，但是解决的问题是不一样的。
             * 
             * 中心思想：一些重复出现的问题可以用一种简单的语言来进行表达，复杂的问题是由简单的问题组合起来的时候，可以用解释器模式。
             */

        }
    }
}
