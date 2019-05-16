using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibilityPattern.RealWord.Approvers
{
    /// <summary>
    /// 经理
    /// </summary>
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessLeaveRequest(LeaveRequest request)
        {
            if (request.Day <= 3)
            {
                Console.WriteLine($"请假天数：{request.Day},{Name}审批通过");
            }
            else
            {
                Console.WriteLine("经理审批不了");
                if (NextApprover != null)
                {
                    NextApprover.ProcessLeaveRequest(request);
                }
            }
        }
    }
}
