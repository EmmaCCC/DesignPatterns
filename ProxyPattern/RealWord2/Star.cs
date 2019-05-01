using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord2
{
    public class Star : Interviewer
    {
        public string Name { get; set; }

        public bool AllowedSay { get; set; } = false;
        public override string AcceptInterview(string question)
        {
            return $"{Name}:我很忙，请找我的经纪人";
        }
    }
}
