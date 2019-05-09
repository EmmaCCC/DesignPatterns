using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RealWord.HttpHandlers
{
    public class AshxHttpHandler : IHttpHandler
    {
        public bool CanAccept(string url)
        {
            return url.EndsWith(".ashx");
        }

        public void ProcessRequest(HttpContext context)
        {
           Console.WriteLine("这是一个一般处理程序请求，我处理了,返回 200 ");
        }
    }
}
