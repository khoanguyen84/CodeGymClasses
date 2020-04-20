using System;

namespace OOP1
{
    class Student
    {
        private string fullName;        
        private string email;
        private string phoneNumber;
        private double score1;
        private double score2;
        private double score3;

        public static string className = "C0120";

        public Student()
        {

        }

        public Student(string fn)
        {
            fullName = fn;
        }

        public Student(string fn, string e, string p)
        {
            fullName = fn;
            email = e;
            phoneNumber = p;
        }
        public string FullName
        {
            get { 
                return fullName;
            }
            set 
            {
                fullName = value;
            }
        }

        public string Email
        {
            get => email;
            set => email = value; 
        }

        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string newPN)
        {
            phoneNumber = newPN;
        }

        public double Score1{
            get => score1;
            set => score1 = value;
        }

        public double Average(){
            return (score1 + score2 + score3)/3;
        }
    }
}