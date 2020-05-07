using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    class PhoneBookDemo
    {
        public Contact[] contacts = new Contact[0];
        public ArrayList arrayList = new ArrayList();
        public List<Contact> list = new List<Contact>();

        public Stack Stack = new Stack(4);
        

        public void Add(Contact c)
        {
            arrayList.Add(c);
        }

        public void AddToList(Contact c)
        {
            list.Add(c);
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
