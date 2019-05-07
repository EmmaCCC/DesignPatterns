using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.RealWord
{
    /// <summary>
    /// 小白DIY电脑组装者
    /// </summary>
    public class XiaoBaiDIYerComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public Computer Build()
        {
            return _computer;
        }

        public IComputerBuilder UseCpu()
        {
            _computer.Cpu = "奔腾G3220";
            return this;
        }

        public IComputerBuilder UseGraphics()
        {
            _computer.Graphics = "GT 610";
            return this;
        }

        public IComputerBuilder UseMemory()
        {
            _computer.Memory = "金士顿 4G DDR2";
            return this;
        }
    }
}
