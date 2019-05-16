using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibilityPattern.RealWord.Approvers
{
    public class Boss : Approver
    {
        public Boss(string name) : base(name)
        {
        }

        public override void ProcessLeaveRequest(LeaveRequest request)
        {
            Console.WriteLine($"请假天数:{request.Day},{Name}审批通过");
        }
    }
}
