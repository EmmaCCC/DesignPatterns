using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RealWord.HttpHandlers
{
    public class AspxHttpHandler: IHttpHandler
    {
        public bool CanAccept(string url)
        {
            return url.EndsWith(".aspx");
        }

        public void ProcessRequest(HttpContext context)
        {
           Console.WriteLine("这是一个aspx页面请求，我处理了,返回<html><div>aspx页面</div></html>");
        }
    }
}
