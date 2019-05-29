using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.RealWord
{
    /// <summary>
    /// 士兵
    /// </summary>
    public class Soldier
    {
        public void Action(string cmd)
        {
            Console.WriteLine($"执行命令：{cmd}");
        }
    }
}
