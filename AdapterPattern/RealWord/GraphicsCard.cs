using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord
{
    public class GraphicsCard
    {
        public void Work(IHDMIInterfaceTarget hdmi)
        {
            hdmi.DisplayHDMISignal();
        }
    }
}
