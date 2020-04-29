using System;
using System.Collections.Generic;
using System.Text;

namespace NewsManagement
{
    class Contact
    {
        private string name { get; set; }
        private string phoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
    }
}
