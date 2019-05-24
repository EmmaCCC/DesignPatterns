using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern.RealWord.Characters
{
    class CharacterB : Character
    {
        public CharacterB()
        {
            this.Symbol = "B";
            this.Height = 100;
            this.Width = 60;
        }
        public override void Display(string color, int pointSize)
        {
            Console.WriteLine($"字符：{Symbol},设置颜色：{color},磅值：{pointSize}");
        }
    }
}
