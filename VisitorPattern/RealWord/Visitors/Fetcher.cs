using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.RealWord.Medicines;

namespace VisitorPattern.RealWord.Visitors
{
    /// <summary>
    /// 取药员（作为又一个访问药品的访问者，操作是取药）
    /// </summary>
    public class Fetcher : Visitor
    {
        public override void Visit(XiaoYanMedicine medicine)
        {
            Console.WriteLine($"取药，名字：{medicine.Name}");
        }

        public override void Visit(ZhiTengMedicine medicine)
        {
            Console.WriteLine($"取药，名字：{medicine.Name}");
        }
    }
}
