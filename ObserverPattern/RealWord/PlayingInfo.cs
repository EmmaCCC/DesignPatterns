using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.RealWord
{
    /// <summary>
    /// 直播的信息
    /// </summary>
    public class PlayingEventArgs
    {
        /// <summary>
        /// 开播的主播
        /// </summary>
        public DouyuZhubo Sender { get; set; }

        /// <summary>
        /// 正在直播的内容，比如：LOL，吃鸡啥的
        /// </summary>
        public string PlayingContent { get; set; }

      

    }
}
