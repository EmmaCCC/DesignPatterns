using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.RealWord
{
    /// <summary>
    /// 专业的DIY电脑组装者
    /// </summary>
    public class ProfessionalDIYerComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public Computer Build()
        {
            return _computer;
        }

        public IComputerBuilder UseCpu()
        {
            _computer.Cpu = "i7 7700";
            return this;
        }

        public IComputerBuilder UseGraphics()
        {
            _computer.Graphics = "GTX 1660";
            return this;
        }

        public IComputerBuilder UseMemory()
        {
            _computer.Memory = "金士顿 骇客神条 16G DDR4";
            return this;
        }
    }
}
