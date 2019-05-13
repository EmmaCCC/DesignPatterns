using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.RealWord
{
    /// <summary>
    /// 可迭代的接口
    /// </summary>
    public interface IIteratorable
    {
        IIterator GetIterator();
    }
}
