using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.RealWord.States
{
    /// <summary>
    /// 黄金会员
    /// </summary>
    public class GoldVipState : AccountState
    {
        public GoldVipState()
        {
            this.Name = "黄金会员";
            this.LowerLimit = 500;
            this.UpperLimit = 1000;
        }
        public override void Process(Account account)
        {
            //如果当前余额小于下线，那就是上一级的白银会员，还可能比白银会员更低
            if (account.Balance < this.LowerLimit)
            {
                account.State = new SilverVipState();
            }

        }
    }
}
