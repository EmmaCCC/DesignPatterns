using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWord
{
    /// <summary>
    /// 复杂图形，包括其他图形
    /// </summary>
    public class ComplexGraphics : Graphics
    {
        private List<Graphics> _graphics = new List<Graphics>();

        public ComplexGraphics(string name) : base(name)
        {
        }

        public override void Draw()
        {
            foreach (var item in _graphics)
            {
                item.Draw();
            }
        }

        public void AddGraphics(Graphics g)
        {
            this._graphics.Add(g);
        }
        public void RemoveGraphics(Graphics g)
        {
            this._graphics.Remove(g);
        }

    }
}
