using System;
using System.Collections.Generic;
using System.Text;
using IteratorPattern.RealWord;

namespace IteratorPattern.RealWord2
{
    /// <summary>
    /// 大小写合并迭代器
    /// </summary>
    public class UpperAndLowerIterator : IIterator
    {
        private int _index = -1;

        private Alphabet _alphabet;
        public UpperAndLowerIterator(Alphabet alphabet)
        {
            _alphabet = alphabet;
        }

        public bool MoveNext()
        {
            if (_index < 26 - 1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public object GetCurrent()
        {
            return _alphabet.UpperLetters[_index].ToString() + _alphabet.LowerLetters[_index].ToString();
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
