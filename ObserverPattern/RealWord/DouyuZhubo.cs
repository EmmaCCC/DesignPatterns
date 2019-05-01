using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.RealWord
{
    public class DouyuZhubo : IZhubo
    {
        /// <summary>
        /// 所有的关注者
        /// </summary>
        private List<IObserver> _observers = new List<IObserver>();

        public string Name { get; set; }

        public DouyuZhubo(string name)
        {
            this.Name = name;

        }

        /// <summary>
        /// 开播
        /// </summary>
        public void Playing()
        {
            var args = new PlayingEventArgs()
            {
                PlayingContent = "LOL",
                Sender = this
            };
            //把消息通知给所有的观察者
            foreach (var observer in _observers)
            {
                observer.OnPlaying(args);
            }
        }

        /// <summary>
        /// 添加关注
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// 取消关注
        /// </summary>
        /// <param name="observer"></param>
        public void RemoveObserver(IObserver observer)
        {
            var ob = _observers.Find(a => a.Name == observer.Name);
            if (ob != null)
            {
                _observers.Remove(ob);
            }
        }
    }
}
