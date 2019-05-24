using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern.RealWord.Characters
{
    /// <summary>
    /// 字符a
    /// </summary>
    class CharacterA : Character
    {
        public CharacterA()
        {
            //这些都是原始属性，每一个字符都可以共享
            this.Symbol = "A";
            this.Height = 100;
            this.Width = 50;
        }

        /// <summary>
        /// 打印的时候我们可以设置字符的颜色和磅值
        /// </summary>
        /// <param name="color"></param>
        /// <param name="pointSize"></param>
        public override void Display(string color, int pointSize)
        {
            Console.WriteLine($"字符：{Symbol},设置颜色：{color},磅值：{pointSize}");
        }
    }
}
