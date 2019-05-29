using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord2.States
{
    /// <summary>
    /// 高级风速
    /// </summary>
    public class HighLevel : SwitchState
    {
        public HighLevel()
        {
            this.Name = "高级";
        }
        public override void Action(SpeedSwitch speedSwitch)
        {
            speedSwitch.SwitchState = new LowLevel();
        }
    }
}
