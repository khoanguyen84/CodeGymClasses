using System;
using System.Collections.Generic;
using System.Text;

namespace Inherit
{
    class Human
    {
        public string Name { get; set; }
        public class Asian : Human 
        {
            public string SkinColor { get; set; }
        }
    }

    class Person
    {

        //Access modifier
        // Public
        // Protected
        // Private
        // internal

        public Person(string fullName, string address)
        {
            this.fullName = fullName;
            this.address = address;
        }

        protected string bankAccount;
        private string fullName;
        private string address;

        public string BackAccount
        {
            get => bankAccount;
            set => bankAccount = value;
        }

        public string FullName
        {
            get => this.fullName;
        }

        public string Address
        {
            get => address;
        }

        public override string ToString()
        {
            return $"Fullname: {fullName}\nAddress: {address}\nBank Account: {bankAccount}";
        }

        public virtual string Sologen()
        {
            return "Still breath still alive";
        }

    }

    class Staff : Person
    {
        private string email { get; set; }
        public Staff(string fn, string e, string a): base(fn, a)
        {
            email = e;
        }

        public string Email
        {
            get => email;
        }

        public override string ToString()
        {
            //return $"{base.Greeting()}\nEmail: {email}";
            return $"Fullname: {FullName}\nEmail: {email}";
        }

        public override sealed string Sologen()
        {
            return $"1 + 1 = 2";
        }
    }

    class Manager : Staff
    {
        private string department;

        public Manager(string f, string e, string a, string d) : base(f, e, a)
        {
            department = d;
        }

        public string Department
        {
            get => department;
        }

        public override string ToString()
        {
            return $"Fullname: {FullName}\nDepartment: {department}";
        }
    }

    class Animal
    {

    }
}
