using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.RealWord.Medicines;

namespace VisitorPattern.RealWord
{
    /// <summary>
    /// 访问者抽象类
    /// </summary>
    public abstract class Visitor
    {
        public abstract void Visit(XiaoYanMedicine medicine);

        public abstract void Visit(ZhiTengMedicine medicine);

    }
}
