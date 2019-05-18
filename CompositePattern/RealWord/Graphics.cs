using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.RealWord
{
    /// <summary>
    /// 图形类
    /// </summary>
    public abstract class Graphics
    {
        public string Name { get; set; }

        protected Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }
}
