using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.RealWord
{
    /// <summary>
    /// 电脑组装指导(说明书）
    /// </summary>
    public class Director
    {
        /// <summary>
        /// 指南（一定要按顺序组）
        /// </summary>
        /// <param name="computerBuilder"></param>
        public Computer Guide(IComputerBuilder computerBuilder)
        {
            ///这里指导 必须按这个顺序组装，且只能每个方法调用一次，防止外部随意调用
            ///当然后来发展的建造者模式就没有这一步了
           return computerBuilder.UseCpu()
                .UseMemory()
                .UseGraphics().Build();
        }
    }
}
