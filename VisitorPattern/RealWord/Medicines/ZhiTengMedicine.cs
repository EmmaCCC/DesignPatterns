using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.RealWord.Medicines
{
    /// <summary>
    /// 止疼药类
    /// </summary>
    public class ZhiTengMedicine : Medicine
    {
        public ZhiTengMedicine(string name, int price) : base(name, price)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
