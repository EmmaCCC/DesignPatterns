using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.RealWord2
{
    /// <summary>
    /// 经纪人类
    /// </summary>
    public class Broker : Interviewer
    {
        private Star _star;
        public Broker(Star star)
        {
            this._star = star;
        }
        public override string AcceptInterview(string question)
        {
            if (question == "请问刘强东的事是怎么了")
            {
                //如果东哥坦荡，允许说，那就说
                if (_star.AllowedSay)
                {
                    return "对不起，东哥对不起大家，东哥确实xxx了。";
                }
                //东哥害怕，不让说
                return "对不起，大家不要听信谣言，事情不是你们想的那样";
            }
            if (question == "请问刘强东多大了")
            {
                return "这个可以说，50岁了";
            }
            else
            {
                return "东哥，这个问题说还是不说啊";
            }
        }
    }
}
