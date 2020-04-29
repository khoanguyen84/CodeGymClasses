using System;
using System.Collections.Generic;
using System.Text;

namespace NewsManagement
{
    class PhoneBook : Phone
    {

        #region fields

        public Contact[] PhoneList = new Contact[0];

        private int numberOfContacts => PhoneList.Length;

        #endregion


        #region public methods
        /// <summary>
        /// allow insert into PhoneBook new contact
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        public override void InsertPhone(string name, string phoneNumber)
        {
            Array.Resize(ref PhoneList, numberOfContacts + 1);

            PhoneList[numberOfContacts - 1] = new Contact(name, phoneNumber);

            Console.WriteLine("Insert new contact successfully");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nane"></param>
        public override void RemovePhone(string name)
        {
            var pos = Check(name);

            if(pos >= 0)
            {
                for (int j = pos; j < numberOfContacts - 1; j++)
                {
                    PhoneList[j] = PhoneList[j + 1];
                }
                Array.Resize(ref PhoneList, numberOfContacts - 1);

                Console.WriteLine("remove a contact successfully");
            }
            else
            {
                Console.WriteLine("not found contact");
            }
        }

        public override void SearchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region private methods

        private int Check(string name)
        {
            for (int i = 0; i < numberOfContacts; i++)
            {
                if (string.Compare(PhoneList[i].Name, name) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion
    }
}
