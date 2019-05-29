using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord.States
{
    /// <summary>
    /// 白银会员
    /// </summary>
    public class SilverVipState : AccountState
    {
        public SilverVipState()
        {
            this.Name = "白银会员";
            this.LowerLimit = 100;
            this.UpperLimit = 500;
        }
        public override void Process(Account account)
        {
            if (account.Balance < this.LowerLimit)
            {
                account.State = new BronzeVipState();
            }
            if (account.Balance > this.UpperLimit)
            {
                account.State = new GoldVipState();
            }
        }
    }
}
