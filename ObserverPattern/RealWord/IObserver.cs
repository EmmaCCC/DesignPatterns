using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.RealWord
{
    public interface IObserver
    {
        string Name { get; set; }
        void OnPlaying(PlayingEventArgs args);
    }
}
