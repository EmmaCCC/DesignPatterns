using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInstancePattern
{
    public class Singleton2
    {
        public Guid Id { get; set; }
        static Singleton2()
        {
            Current = new Singleton2();
        }
        private Singleton2()
        {
            Id = Guid.NewGuid();
        }

        public static Singleton2 Current { get; }
    }
}
