using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord2
{
    /// <summary>
    /// 开关状态
    /// </summary>
    public abstract class SwitchState
    {
        public string Name { get; set; }
        public abstract void Action(SpeedSwitch speedSwitch);

    }
}
