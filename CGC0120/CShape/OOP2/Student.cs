using System;

namespace OOP2
{
    class Student
    {
        private string fullName;
        private string email;
        private string phoneNumber;
        private double score1;
        private double score2;

        public static string className = "C0120";

        public Student()
        {

        }

        public Student(string fn)
        {
            fullName = fn;
        }

        public Student(string fn, string e, string p){
            fullName = fn;
            email = e;
            phoneNumber = p;
        }

        //getter and setter
        //C1
        public string GetFullName()
        {
            return  fullName;
        }

        public void SetFullName(string newFN)
        {
            fullName = newFN;
        }

        //C2
        public string Email
        {
            get {
                return email;
            }
            set {
                email = value;
            }
        }

        //C3
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public static string ClassCode()
        {
            return "We are family";
        }

        public double Score1
        {
            get => score1;
            set => score1 = value;
        }
        public double Score2
        {
            get => score2;
            set => score2 = value;
        }

        public double Average()
        {
            return (score1 * 2 + score2)/3;
        }
    }
}