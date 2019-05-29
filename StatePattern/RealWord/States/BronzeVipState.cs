using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord.States
{
    /// <summary>
    /// 青铜会员
    /// </summary>
    public class BronzeVipState:AccountState
    {
        public BronzeVipState()
        {
            this.Name = "青铜会员";
            this.LowerLimit = 0;
            this.UpperLimit = 100;
        }
        public override void Process(Account account)
        {
            if (account.Balance > this.UpperLimit)
            {
                account.State = new SilverVipState();
            }

        }
    }
}
