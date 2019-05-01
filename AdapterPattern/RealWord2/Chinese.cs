using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord2
{
    public class Chinese
    {
        public string Hello { get; set; }
        public Chinese(string hello)
        {
            Hello = hello;
        }
    }
}
