using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.RealWord2.States;

namespace StatePattern.RealWord2
{
    /// <summary>
    /// 风速开关
    /// </summary>
    public class SpeedSwitch
    {
        public SwitchState SwitchState { get; set; }

        public SpeedSwitch()
        {
            this.SwitchState = new LowLevel();
        }

        /// <summary>
        /// 下一级风速
        /// </summary>
        public void Next()
        {
            SwitchState.Action(this);
        }


        public void Display()
        {
            Console.WriteLine($"当前风速：{this.SwitchState.Name}");
        }
    }
}
