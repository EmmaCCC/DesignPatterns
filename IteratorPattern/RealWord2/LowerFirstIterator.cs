using System;
using System.Collections.Generic;
using System.Text;
using IteratorPattern.RealWord;

namespace IteratorPattern.RealWord2
{
    public class LowerFirstIterator : IIterator
    {
        private int _index = -1;

        private Alphabet _alphabet;
        public LowerFirstIterator(Alphabet alphabet)
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
                return _alphabet.LowerLetters[_index];
            }
            return _alphabet.UpperLetters[_index - 26];
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
