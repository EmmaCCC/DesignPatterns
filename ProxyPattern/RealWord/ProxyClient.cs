using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord
{
    class ProxyClient : IClient
    {
        private ChinaClient _client = new ChinaClient();

        public string ClientIp => "Not China Ip";

        public ProxyClient()
        {

        }
        public ProxyClient(ChinaClient client)
        {
            this._client = client;
        }

        public void Request()
        {
            //一顿请求 调用WebRequest请求到内容
            var content = "google";
            _client.Content = content;
            _client.Request();
        }
    }
}
