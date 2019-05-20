using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.RealWord
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class ContactPersonMemento
    {
        public List<ContactPerson> ContactPersons { get; }
        public ContactPersonMemento(List<ContactPerson> contactPeople)
        {
            this.ContactPersons = contactPeople;
        }
    }
}
