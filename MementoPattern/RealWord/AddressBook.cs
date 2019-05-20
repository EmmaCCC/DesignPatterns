using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.RealWord
{
    /// <summary>
    /// 通讯录
    /// </summary>
    public class AddressBook
    {
        private List<ContactPerson> _contactPersons;

        public AddressBook(List<ContactPerson> contactPersons)
        {
            this._contactPersons = contactPersons;
        }

        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public ContactPersonMemento CreateContactPersonMemento()
        {
            return new ContactPersonMemento(new List<ContactPerson>(this._contactPersons));
        }

        /// <summary>
        /// 从备忘录还原联系人
        /// </summary>
        /// <param name="personMemento"></param>
        public void RestoreContactPersonFromMemento(ContactPersonMemento personMemento)
        {
            this._contactPersons = personMemento.ContactPersons;
        }

        /// <summary>
        /// 删除联系人
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
           _contactPersons.Remove(_contactPersons.Find(a => a.Name == name));
        }

        public void Show()
        {
            foreach (var contactPerson in _contactPersons)
            {
                Console.WriteLine($"联系人：{contactPerson.Name},电话：{contactPerson.Phone}");
            }
        }
    }
}
