using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord2.States
{
    /// <summary>
    /// 中级风速
    /// </summary>
    public class MidLevel : SwitchState
    {
        public MidLevel()
        {
            this.Name = "中级";
        }
        public override void Action(SpeedSwitch speedSwitch)
        {
            speedSwitch.SwitchState = new HighLevel();
        }
    }
}
