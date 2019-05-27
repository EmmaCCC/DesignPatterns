using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.RealWord.Medicines
{
    /// <summary>
    /// 消炎药类
    /// </summary>
    public class XiaoYanMedicine : Medicine
    {
        public XiaoYanMedicine(string name, int price) : base(name, price)
        {

        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
