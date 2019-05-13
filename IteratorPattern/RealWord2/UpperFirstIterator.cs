using System;
using System.Collections.Generic;
using System.Text;
using IteratorPattern.RealWord;

namespace IteratorPattern.RealWord2
{
    /// <summary>
    /// 大写优先迭代器
    /// </summary>
    public class UpperFirstIterator : IIterator
    {
        private int _index = -1;

        private Alphabet _alphabet;
        public UpperFirstIterator(Alphabet alphabet)
        {
            _alphabet = alphabet;
        }

        public bool MoveNext()
        {
            if (_index < 52 - 1)
            {
                _index++;
                return true;
            }
            return false;
        }

        public object GetCurrent()
        {
            if (_index <= 26 - 1)
            {
                return _alphabet.UpperLetters[_index];
            }
            return _alphabet.LowerLetters[_index - 26];
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
