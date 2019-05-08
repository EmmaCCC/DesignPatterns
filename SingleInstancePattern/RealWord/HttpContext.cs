using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInstancePattern.RealWord
{
    public class HttpContext
    {

        public string Request { get; set; }
        public string Response { get; set; }

        public static readonly HttpContext Current;

        private HttpContext()
        {
            this.Request = "https://www.baidu.com";
            this.Response = "hello word";
        }

        static HttpContext()
        {
            //通过某种手段已经把当前HttpReques和Response封装好了，这里模拟一下
            Current = new HttpContext();
        }
    }
}
