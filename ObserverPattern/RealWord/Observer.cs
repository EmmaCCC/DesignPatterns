using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.RealWord
{
    /// <summary>
    /// 关注的人
    /// </summary>
    public class Observer: IObserver
    {
        public string Name { get; set; }
        public Observer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 通过这个方法获取主播直播的消息
        /// </summary>
        /// <param name="args"></param>
        public void OnPlaying(PlayingEventArgs args)
        {
            Console.WriteLine($"我是{Name}");
            Console.WriteLine($"收到主播开播消息:");
            Console.WriteLine($"主播:{args.Sender.Name},正在直播：{args.PlayingContent}");
        }
    }
}
