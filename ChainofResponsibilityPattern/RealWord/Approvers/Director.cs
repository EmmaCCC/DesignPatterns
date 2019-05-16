using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibilityPattern.RealWord.Approvers
{
    /// <summary>
    /// 总监
    /// </summary>
    public class Director : Approver
    {
        public Director(string name) : base(name)
        {
        }

        public override void ProcessLeaveRequest(LeaveRequest request)
        {
            if (request.Day > 3 && request.Day < 6)
            {
                Console.WriteLine($"请假天数：{request.Day},{Name}审批通过");

            }
            else
            {
                Console.WriteLine("总监审批不了");
                if (NextApprover != null)
                {
                    NextApprover.ProcessLeaveRequest(request);
                }
            }
        }
    }
}
