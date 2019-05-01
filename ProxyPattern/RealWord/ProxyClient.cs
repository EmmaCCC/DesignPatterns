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
            //把请求到的内容给真实的中国客户端
            _client.Content = content;
            //展示真实客户端的结果，也可以不调用，看情况，反正已经拿到了数据
            _client.Request();
        }
    }
}
