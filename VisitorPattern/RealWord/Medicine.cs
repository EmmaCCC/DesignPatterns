using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.RealWord
{
    /// <summary>
    /// 药品
    /// </summary>
    public abstract class Medicine
    {
        public Medicine(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 接受一个访问者
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(Visitor visitor);
        
    }
}
