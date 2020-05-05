using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo.HashTable
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable hb1 = new Hashtable();
            hb1.Add("12345", new Student() 
                            {
                                Fullname = "Tin Nguyen",
                                DoB = DateTime.Parse("10/10/2000")
                            });
            hb1.Add("12346", new Student()
                            {
                                Fullname = "Trung Nguyen",
                                DoB = DateTime.Parse("10/10/2000")
                            });
            hb1.Add("12347", new Student()
                            {
                                Fullname = "Minh Nguyen",
                                DoB = DateTime.Parse("10/10/2000")
                            });
            hb1.Add("12348", new Student()
                            {
                                Fullname = "Tram Nguyen",
                                DoB = DateTime.Parse("10/10/2000")
                            });
            hb1.Add("12349", new Student()
                            {
                                Fullname = "Ghi Nguyen",
                                DoB = DateTime.Parse("10/10/2000")
                            });

            foreach(var item in hb1.Keys)
            {
                Console.WriteLine(hb1[item].ToString());
            }

            hb1.Remove("12345");
            Console.WriteLine("---------- after remove ----------------");
            foreach (var item in hb1.Keys)
            {
                Console.WriteLine(hb1[item].ToString());
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
