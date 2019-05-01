using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.RealWord2
{
    /// <summary>
    /// 翻译官，肯定会说英语
    /// </summary>
    public class Translator : ICanSayEnglish
    {
        private Chinese _chinese;
        public Translator(Chinese chinese)
        {
            this._chinese = chinese;
        }
        public string SayEnglish()
        {
            var lang = _chinese.Hello;
            //看的懂这句话，就翻译
            if(lang == "你好,早饭吃了吗")
            {
                return "Hello,did you have breakfast?";
            }
            //看不懂，就是早上好
            return "你好,早饭吃了吗";
        }
    }
}
