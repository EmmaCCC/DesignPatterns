using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern.RealWord
{
    /// <summary>
    /// 收费最少路线策略
    /// </summary>
    public class FeeLeastRouter : IRouter
    {
        public string RouteName { get => "京沪高速（收费最少）";}

        public string GetRouteDetail()
        {
            return "时间：9小时48分；距离：810公里；过路费：100元";
        }
    }
}
