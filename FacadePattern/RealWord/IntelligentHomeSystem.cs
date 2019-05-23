using FacadePattern.RealWord.SubSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.RealWord
{
    /// <summary>
    /// 智能家居系统
    /// </summary>
    public class IntelligentHomeSystem
    {
        private IntelligentAirCondiction airCondiction = new IntelligentAirCondiction();
        private IntelligentLight  light = new IntelligentLight();
        private IntelligentTv tv = new IntelligentTv();
        /// <summary>
        /// 回家模式
        /// </summary>
        public void GoHomeMode()
        {
            light.On();
            airCondiction.On();
            tv.On();
        }

        /// <summary>
        /// 离家模式
        /// </summary>
        public void LeaveHomeMode()
        {
            light.Off();
            airCondiction.Off();
            tv.Off();
        }

    }
}
