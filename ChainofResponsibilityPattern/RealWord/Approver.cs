using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibilityPattern.RealWord
{
    public abstract class Approver
    {
        public string Name { get; set; }

        public Approver NextApprover { get; set; }

        public abstract void ProcessLeaveRequest(LeaveRequest request);

        protected Approver(string name)
        {
            this.Name = name;
        }
    }
}
