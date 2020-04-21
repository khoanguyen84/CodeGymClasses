using System;
using System.Collections.Generic;
using System.Text;

namespace Phone
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string ShowContact()
        {
            return $"Name: {Name}\tPhone number: {PhoneNumber}";
        }
    }
}
