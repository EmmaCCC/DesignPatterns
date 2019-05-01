using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord2
{
    /// <summary>
    /// 能接受采访抽象类，这次我们用抽象类来代替接口，效果是一样的。
    /// </summary>
    public abstract class Interviewer
    {
        /// <summary>
        /// 接受采访
        /// </summary>
        /// <param name="question"></param>
        /// <returns></returns>
        public abstract string AcceptInterview(string question);
    }
}
