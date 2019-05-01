using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord
{
    public interface IClient
    {
        /// <summary>
        /// 客户端的ip地址
        /// </summary>
        string ClientIp { get; }

        /// <summary>
        /// 请求获取内容
        /// </summary>
        /// <returns></returns>
        void Request();
    }
}
