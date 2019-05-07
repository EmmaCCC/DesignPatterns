using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.RealWord
{
    public interface IComputerBuilder
    {
        //这里返回的类型也可以为空，返回IComputerBuilder是为了用Flunt方式调用

        /// <summary>
        /// 使用(建造)cpu
        /// </summary>
        /// <returns></returns>
        IComputerBuilder UseCpu();

        /// <summary>
        /// 使用(建造)显卡
        /// </summary>
        /// <returns></returns>
        IComputerBuilder UseGraphics();

        /// <summary>
        /// 使用(建造)内存条
        /// </summary>
        /// <returns></returns>
        IComputerBuilder UseMemory();

        /// <summary>
        /// 组装好电脑
        /// </summary>
        /// <returns></returns>
        Computer Build();
    }
}
