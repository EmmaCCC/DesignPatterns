using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWord
{
    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : Graphics
    {
        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"画{Name}");
        }
    }
}
