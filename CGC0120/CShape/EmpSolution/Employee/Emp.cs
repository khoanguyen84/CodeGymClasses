using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Emp
    {
        private string name;
        private string email;
        private DateTime dob;
        private string address;

        public string phoneNumber { get; private set; }

        public string PhoneNumber
        {
            set => phoneNumber = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Email { get => email; set => email = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Address
        {
            get => address;
            set => address = value;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - dob.Year;
        }

        public string GetInfo()
        {
            return $"| Name: {name}\t| Email: {email}\t| DoB: {dob.ToString("dd/MM/yyyy")}\t| Age: {GetAge()}";
        }
    }
}
