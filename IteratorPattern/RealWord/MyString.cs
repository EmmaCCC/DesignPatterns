namespace IteratorPattern.RealWord
{
    public class MyString : IIteratorable
    {
        public char[] Arr { get; }
        public int Length { get; }

        public MyString(string str)
        {
            Arr = str.ToCharArray();
            Length = str.Length;
        }

        public IIterator GetIterator()
        {
            return new StringToCharIterator(this);
        }
    }
}