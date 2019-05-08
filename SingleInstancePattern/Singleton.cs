using System;

namespace SingleInstancePattern
{
    public class Singleton
    {
        private static Singleton _singleton = null;

        private static object locker = new object();

        private Singleton()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public static Singleton GetSingleton()
        {
            //这里如果是多线程访问的话，可以同时进来判断都为null,然后就都new，就成了多例了
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }

        public static Singleton GetSingleton2()
        {
            //多线程这里要加锁，防止并发导致出现多例
            //但是每次获取都要加锁，性能上又回有所损失
            lock (locker)
            {
                if (_singleton == null)
                {
                    _singleton = new Singleton();
                }
            }
            return _singleton;
        }


        public static Singleton GetSingleton3()
        {
            //这里只在为null的情况下才加锁，不为null直接返回就行了。
            if (_singleton == null)
            {
                lock (locker)
                {
                    if (_singleton == null)
                    {
                        _singleton = new Singleton();
                    }
                }
            }
            return _singleton;
        }
    }
}