using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern.RealWord
{
    /// <summary>
    /// 系统内置字符
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// 名称标记
        /// </summary>
        protected string Symbol { get; set; }
        /// <summary>
        /// 原始高度
        /// </summary>
        protected int Height { get; set; }
        /// <summary>
        /// 原始宽度
        /// </summary>
        protected int Width { get; set; }
        /// <summary>
        /// 打印的时候我们可以设置字符的颜色和磅值
        /// </summary>
        /// <param name="color">字符的颜色</param>
        /// <param name="pointSize">字符的磅值</param>
        public abstract void Display(string color, int pointSize);
    }
}
