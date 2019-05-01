using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.RealWord
{
    /// <summary>
    /// 主播接口
    /// </summary>
    public interface IZhubo
    {
        /// <summary>
        /// 开播
        /// </summary>
        void Playing();

        /// <summary>
        /// 加关注
        /// </summary>
        /// <param name="observer"></param>
        void AddObserver(IObserver observer);

        /// <summary>
        /// 取消关注
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(IObserver observer);
    }
}
