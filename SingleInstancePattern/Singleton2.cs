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
            Instance = new Singleton2();
        }
        private Singleton2()
        {
            Id = Guid.NewGuid();
        }

        public static readonly Singleton2 Instance;
    }
}
