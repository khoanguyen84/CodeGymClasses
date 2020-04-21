using System;
using System.Collections.Generic;
using System.Text;

namespace Phone
{
    class PhoneBook
    {
        public Contact[] ContactList = new Contact[0];

        public void Add(ref Contact[] ctList, Contact contact)
        {
            Array.Resize(ref ctList, ctList.Length + 1);
            ctList[ctList.Length - 1] = contact;
        }

        public bool Check(string name, out int pos)
        {
            for(var i = 0; i<ContactList.Length; i++)
            {
                if(ContactList[i].Name.ToLower() == name.ToLower())
                {
                    pos = i;
                    return true;
                }
            }
            pos = -1;
            return false;
        }

        public void Update(string name, string newPhone)
        {
            if (Check(name, out int pos))
            {
                ContactList[pos].PhoneNumber = newPhone;
            }
        }

        public void Remove(ref Contact[] ctList, string name)
        {
            if(Check(name, out int pos))
            {
                for(int i= pos; i<ctList.Length - 1; i++)
                {
                    ctList[i] = ctList[i + 1];
                }
                Array.Resize(ref ctList, ctList.Length - 1);
            }
        }

        public string Search(string name)
        {
            foreach(var contact in ContactList)
            {
                if(contact.Name.ToLower() == name.ToLower())
                {
                    return contact.ShowContact();
                }
            }
            return $"Not exist";
        }

        public string ShowPhoneBook()
        {
            string showPB = "Phone Book\n";
            foreach(var contact in ContactList)
            {
                showPB = $"{showPB}\n{contact.ShowContact()}";
            }
            return showPB;
        }
    }
}
