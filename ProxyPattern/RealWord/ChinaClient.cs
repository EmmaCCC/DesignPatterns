using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord
{
    class ChinaClient : IClient
    {
        public string ClientIp => "China Ip";

        public string Content { get;  set; }

        
        public void Request()
        {
            Console.WriteLine($"Ip地址：{ClientIp}，请求到内容：{Content}");
        }

    }
}
