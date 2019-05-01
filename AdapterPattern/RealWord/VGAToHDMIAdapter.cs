using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord
{
    /// <summary>
    /// VGA转HDMI适配器
    /// </summary>
    public class VGAToHDMIAdapter : IHDMIInterfaceTarget
    {
        private VGAInterface vga;

        public VGAToHDMIAdapter(VGAInterface vga)
        {
            this.vga = vga;
        }

        public void DisplayHDMISignal()
        {
            var signal = VGAtoHDMISignal();
            Console.WriteLine($"转换成HDMI信号：{signal}");
        }

        /// <summary>
        /// //适配器转换信号操作
        /// </summary>
        /// <returns></returns>
        private string VGAtoHDMISignal()
        {
            var signal = vga.ConnectAapter();
            Console.WriteLine($"适配器转换信号...");
            if (signal.StartsWith("VGA"))
            {
                return signal.Replace("VGA", "HDMI");
            }
            return "无法适配";
        }

    }
}
