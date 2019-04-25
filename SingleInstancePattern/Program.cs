using System;
using System.Runtime.InteropServices;

namespace SingleInstancePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetSingleton();
            var singleton2 = Singleton.GetSingleton();

            Console.WriteLine(singleton1.Id);
            Console.WriteLine(singleton2.Id);
            Console.ReadKey();
        }
    }
}
