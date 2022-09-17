using System;
using System.Collections.Generic;

namespace Contacts
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            Contact contact = new Contact("Jala", 555);
            Contact contact1 = new Contact("Sevda", 556);
            Contact contact2 = new Contact("Gunay", 557);
            Contact contact3 = new Contact("Ayan", 558);
            Contact contact4 = new Contact("Fidan", 559);
            Contact contact5 = new Contact("Samire", 560);
            contacts.Add(contact);
            contacts.Add(contact1);
            contacts.Add(contact2);
            contacts.Add(contact3);
            contacts.Add(contact4);
            contacts.Add(contact5);



        }
    }
}
