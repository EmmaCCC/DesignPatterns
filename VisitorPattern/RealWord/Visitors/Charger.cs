using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.RealWord.Medicines;

namespace VisitorPattern.RealWord.Visitors
{
    /// <summary>
    /// 药品划价员（作为一个访问药品的访问者，操作是划价）
    /// </summary>
    public class Charger : Visitor
    {
        public override void Visit(XiaoYanMedicine medicine)
        {
            Console.WriteLine($"药品划价，名字：{medicine.Name}，价格：{medicine.Price}");
        }

        public override void Visit(ZhiTengMedicine medicine)
        {
            Console.WriteLine($"药品划价，名字：{medicine.Name}，价格：{medicine.Price}");

        }
    }
}
