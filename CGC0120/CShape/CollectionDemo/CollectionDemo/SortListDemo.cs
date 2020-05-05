using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo.SortListDemo
{
    class SortListDemo
    {
        public static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("12349", new Student()
            {
                Fullname = "Tin Nguyen",
                DoB = DateTime.Parse("10/10/2000")
            });
            sl.Add("12347", new Student()
            {
                Fullname = "Trung Nguyen",
                DoB = DateTime.Parse("10/10/2000")
            });
            sl.Add("12348", new Student()
            {
                Fullname = "Minh Nguyen",
                DoB = DateTime.Parse("10/10/2000")
            });
            sl.Add("12345", new Student()
            {
                Fullname = "Tram Nguyen",
                DoB = DateTime.Parse("10/10/2000")
            });
            sl.Add("12346", new Student()
            {
                Fullname = "Ghi Nguyen",
                DoB = DateTime.Parse("10/10/2000")
            });

            sl.Add("12344", new Student()
            {
                Fullname = "Quang Nguyen",
                DoB = DateTime.Parse("10/10/2000")
            });

            foreach (var item in sl.Keys)
            {
                Console.WriteLine(sl[item].ToString());
            }
        }
    }
    class Student
    {
        public string Fullname { get; set; }
        public DateTime DoB { get; set; }

        public override string ToString()
        {
            return $"Fullname: {Fullname}, DoB: {DoB.ToString("dd/MM/yyyy")}";
        }
    }
}
