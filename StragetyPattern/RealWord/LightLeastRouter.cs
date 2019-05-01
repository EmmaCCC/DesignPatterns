using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern.RealWord
{
    /// <summary>
    /// 红绿灯最少路线策略
    /// </summary>
    public class LightLeastRouter : IRouter
    {
        public string RouteName { get => "大广高速（红绿灯最少）";}

        public string GetRouteDetail()
        {
            return "时间：8小时25分；距离：700公里；过路费：300元";
        }
    }
}
