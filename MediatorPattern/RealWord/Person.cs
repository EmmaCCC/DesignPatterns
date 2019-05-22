using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.RealWord
{
    public abstract class Person
    {
        public string Name { get; set; }

        public Mediator Mediator { get; set; }

        protected Person(string name,Mediator mediator)
        {
            this.Name = name;
            this.Mediator = mediator;
        }
        public abstract void SendMessage(string message);

        public abstract void GetMessage(string message);

    }
}
