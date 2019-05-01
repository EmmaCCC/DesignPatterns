using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord2
{
    public class English
    {
        public void Answer(string hello)
        {
            if (hello == "Hello,did you have breakfast?")
            {
                Console.WriteLine("Yes,I did");
            }
            else
            {
                Console.WriteLine($"({hello}) en? What do you say?");
            }
        }
    }
}
