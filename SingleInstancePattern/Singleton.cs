using System;

namespace SingleInstancePattern
{
    public class Singleton
    {
        private static Singleton _singleton = null;

        private Singleton()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public static Singleton GetSingleton()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }
    }
}