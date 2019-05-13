using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.RealWord
{
    /// <summary>
    /// MyString这个类所需要的特殊的迭代器实现，不同的类可能要不同的迭代器
    /// </summary>
    
    public class StringToCharIterator : IIterator
    {
        private MyString _str;
        private int _length;
        private int _currentIndex = 0;

        public StringToCharIterator(MyString str)
        {
            this._str = str;
            _length = str.Length;
        }
        public bool MoveNext()
        {
            if (_currentIndex < _length - 1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public object GetCurrent()
        {
            return _str.Arr[_currentIndex];
        }

        public void Reset()
        {
            _currentIndex = 0;
        }

    }
}
