using StragetyPattern.RealWord;
using System;
using System.Collections.Generic;
using System.Text;

namespace StragetyPattern
{
    public class Navigator
    {
        public string From { get; set; }
        public string To { get; set; }

        private IRouter _router;
        public Navigator(string from,string to,IRouter router)
        {
            From = from;
            To = to;
            _router = router;
        }
        public void DisplayRoute()
        {
            Console.WriteLine($"起点：{From}，终点：{To}");
            Console.WriteLine(_router.RouteName);
            Console.WriteLine(_router.GetRouteDetail());
        }
    }
}
