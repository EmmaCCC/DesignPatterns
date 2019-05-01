using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord2
{
    class Reporter
    {
        public void Interview(Interviewer interviewer,string question)
        {
            Console.WriteLine(interviewer.AcceptInterview(question));
        }
    }
}
