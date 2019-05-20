using System;
using System.Collections.Generic;
using MementoPattern.RealWord;

namespace MementoPattern
{
    class Program
    {
        /*
         * 备忘录模式：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态（如果没有这个关键点，其实深拷贝就可以解决问题）。这样以后就可以将该对象恢复到原先保存的状态。——《设计模式》GoF
         * 
         * 模式的组成：
 
            （1）发起人角色（Originator）：记录当前时刻的内部状态，负责创建和恢复备忘录数据。负责创建一个备忘录Memento，用以记录当前时刻自身的内部状态，并可使用备忘录恢复内部状态。Originator【发起人】可以根据需要决定Memento【备忘录】存储自己的哪些内部状态。
                如：[AddressBook]

            （2）备忘录角色（Memento）：负责存储发起人对象的内部状态，在进行恢复时提供给发起人需要的状态，并可以防止Originator以外的其他对象访问备忘录。备忘录有两个接口：Caretaker【管理角色】只能看到备忘录的窄接口，他只能将备忘录传递给其他对象。Originator【发起人】却可看到备忘录的宽接口，允许它访问返回到先前状态所需要的所有数据。
                如：[ContactPersonMemento]

            （3）管理者角色（Caretaker）：负责保存备忘录对象。负责备忘录Memento，不能对Memento的内容进行访问或者操作。
                如：[MementoManager]

         */
        static void Main(string[] args)
        {
            //添加联系人
            List<ContactPerson> contacts = new List<ContactPerson>()
            {
                new ContactPerson()
                {
                    Name = "张三",
                    Phone = "131461654662"
                },
                new ContactPerson()
                {
                    Name = "李四",
                    Phone = "15613256465"
                },
                new ContactPerson()
                {
                    Name = "王五",
                    Phone = "13456893126"
                },
            };

            AddressBook addressBook = new AddressBook(contacts);

            //创建备忘录并保存
            MementoManager.ContactPersonMemento = addressBook.CreateContactPersonMemento();

            Console.WriteLine("==========删除联系人：张三===========");
            //删除一个联系人
            addressBook.Remove("张三");
            addressBook.Show();


            //恢复联系人
            Console.WriteLine("==========恢复联系人===========");
            addressBook.RestoreContactPersonFromMemento(MementoManager.ContactPersonMemento);
            addressBook.Show();

            Console.ReadKey();

            /*
             * 总结：
             * 1.备忘录模式的核心在于每次修改对象的状态之前都要存储一下，这样以后需要的话就可以恢复了。
             * 2.当然每次存储对象的状态，对内存开销是比较大的。
             * 
             * 中心思想：其实就是数据备份功能，存起来到时候好恢复。
             */
        }
    }
}
