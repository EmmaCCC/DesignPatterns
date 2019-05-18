using CompositePattern.RealWord;
using System;

namespace CompositePattern
{
    class Program
    {
        /*
         * 组合模式：将对象组合成树形结构以表示“部分-整体”的层次结构。Composite使得用户对单个对象和组合对象的使用具有一致性。——  《设计模式》GoF
         *  
         *  模式的组成：
    
            （1）、抽象构件角色（Component）：这是一个抽象角色，它给参加组合的对象定义出了公共的接口及默认行为，可以用来管理所有的子对象（在透明式的组合模式是这样的）。在安全式的组合模式里，构件角色并不定义出管理子对象的方法，这一定义由树枝结构对象给出。
                如：[Graphics]

            （2）、树叶构件角色（Leaf）：树叶对象是没有下级子对象的对象，定义出参加组合的原始对象的行为。（原始对象的行为可以理解为没有容器对象管理子对象的方法，或者 【原始对象行为】+【管理子对象的行为（Add，Remove等）】=面对客户代码的接口行为集合）
                如：[Circle,Line]

            （3）、树枝构件角色（Composite）：代表参加组合的有下级子对象的对象，树枝对象给出所有管理子对象的方法实现，如Add、Remove等。
                如：[ComplexGraphics]

           组合模式实现的最关键的地方是——简单对象和复合对象必须实现相同的接口。这就是组合模式能够将组合对象和简单对象进行一致处理的原因。
         */
        static void Main(string[] args)
        {

            //创建一个复杂图形
            ComplexGraphics complexGraphics = new ComplexGraphics("包含两条线段和一个圆的复杂图形");

            //组合其他图形
            complexGraphics.AddGraphics(new Line("线段a"));
            complexGraphics.AddGraphics(new Line("线段b"));
            complexGraphics.AddGraphics(new Circle("一个圆"));

            complexGraphics.Draw();

            Console.ReadKey();


            /*
             * 总结：
             * 1.组合模式是一个对象包含多个对象，并且这些对象都有共同的方法，像搭积木一样，新的对象完全是由这些基础对象组合起来的。
             * 2.组合模式的其实和树形结构差不多，树结构都是一个一个树枝构成，也是典型的组合模式的体现。
             */

            /*
             * 其实组合模式在FCL里面运用还是很多的，不知道大家是不是有所感觉，这个模式大多数是运用在控件上或者是和界面操作、
             * 展示相关的操作上。这个模式在.NET 中最典型的应用就是应用与WinForms和Web的开发中，在.NET类库中，都为这两个平台提供了很多现有的控件，
             * 然而System.Windows.Forms.dll中System.Windows.Forms.Control类就应用了组合模式，因为控件包括Label、TextBox等这样的简单控件，
             * 这些控件可以理解为叶子对象，同时也包括GroupBox、DataGrid这样复合的控件或者叫容器控件，每个控件都需要调用OnPaint方法来进行控件显示，
             * 为了表示这种对象之间整体与部分的层次结构，微软把Control类的实现应用了组合模式。
             */
        }
    }
}
