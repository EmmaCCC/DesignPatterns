using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord
{

    /// <summary>
    /// 老显示器的VGA接口
    /// </summary>
    public class VGAInterface
    {
        public string ConnectAapter()
        {
            Console.WriteLine("VGA 接入转接适配器，发送 VGA_001 信号");
            return "VGA_001";
        }
    }
}
