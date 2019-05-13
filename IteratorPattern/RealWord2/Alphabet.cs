using System;
using System.Collections.Generic;
using System.Text;
using IteratorPattern.RealWord;

namespace IteratorPattern.RealWord2
{
    /// <summary>
    /// 字母表类
    /// </summary>
    public class Alphabet : IIteratorable
    {
        public char[] UpperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public char[] LowerLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public IIterator _iterator;

        public void SetIterator(IIterator iterator)
        {
            _iterator = iterator;
        }

        public IIterator GetIterator()
        {
            return _iterator;
        }
    }
}
