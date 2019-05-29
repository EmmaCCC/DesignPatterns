using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord2.States
{
    /// <summary>
    /// 低级风速
    /// </summary>
    public class LowLevel:SwitchState
    {
        public LowLevel()
        {
            this.Name = "低级";
        }
        public override void Action(SpeedSwitch speedSwitch)
        {
            speedSwitch.SwitchState = new MidLevel();
        }
    }
}
