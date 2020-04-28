using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Student
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        //public string  FullName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public DateTime DoB { get; set; }
        //public int Age { get; set; }
        public int Age => DateTime.Now.Year - DoB.Year;
        public int Module1 { get; set; }
        public int Module2 { get; set; }
        public int Module3 { get; set; }
        public string Result => ((Module1 + Module2 + Module3) / 3 > 75) ? "Đạt" : "Không Đạt";
    }
}
