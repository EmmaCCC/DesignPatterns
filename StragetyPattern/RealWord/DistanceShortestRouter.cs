using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern.RealWord
{
    /// <summary>
    /// 距离最短策略
    /// </summary>
    public class DistanceShortestRouter : IRouter
    {
        public string RouteName { get => "京港澳高速（距离最短）";}

        public string GetRouteDetail()
        {
            return "时间：8小时10分；距离：675公里；过路费：200元";
        }
    }
}
