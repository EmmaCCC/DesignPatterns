using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord
{
    public class TheCreateWall
    {
        private IClient _client;
        public TheCreateWall(IClient client)
        {
            this._client = client;
        }

        public void Check()
        {
            if(_client.ClientIp == "China Ip")
            {
                Console.WriteLine("访问失败，你访问的地址不存在");
            }
            else
            {
                _client.Request();
            }
        }
    }
}
