using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern.RealWord
{
    public interface IRouter
    {
        /// <summary>
        /// 路线名称
        /// </summary>
        string RouteName { get;  }

        /// <summary>
        /// 路线详情
        /// </summary>
        /// <returns></returns>

        string GetRouteDetail();
    }
}
