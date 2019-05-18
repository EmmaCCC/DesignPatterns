using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWord
{
    /// <summary>
    /// 线段
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name) : base(name)
        {

        }

        public override void Draw()
        {
            Console.WriteLine($"画{Name}");
        }
    }
}
