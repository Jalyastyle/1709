using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    public class Contact
    {
        public string name { get; set; }
        public int number { get; set; }


        public Contact(string name,int number)
        {
            this.name = name;
            this.number = number;
        }

        public override string ToString()
        {
            return name + " " + number;
        }
    }
}
