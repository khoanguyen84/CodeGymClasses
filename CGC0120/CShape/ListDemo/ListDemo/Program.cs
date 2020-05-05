using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList()
            //{ 
            //    new Student()
            //    {
            //        Address = "28 NTP",
            //        Fullname = "Khoa Nguyễn"
            //    }
            //};


            //arrayList.Add(new Student()
            //{
            //    Fullname = "Phúc Lê",
            //    Address = "28 NTP"
            //});

            //foreach(Student item in arrayList)
            //{
            //    Console.WriteLine($"Fullname: {item.Fullname}, Address: {item.Address}");
            //}

            //arrayList.Sort(new Comparation());
            //SortedList sortedList = new SortedList();

            //Stack stack = new Stack();

            //Queue queue = new Queue();

            //Hashtable hashtable = new Hashtable();


            ArrayList al = new ArrayList() { 3, 5, 2, 6, 8, 9, 1, 10, 5 };
            al.Sort(new ALComparer());
            foreach(var item in al)
            {
                Console.Write($"{item} ");
            }


        }
    }

    class Student
    {
        public string Fullname { get; set; }
        public string  Address { get; set; }
    }


    //class Comparation : IComparer
    //{
    //    public int Compare(object x, object y)
    //    {
    //        return string.Compare(((Student)x).Fullname, ((Student)y).Fullname);
    //    }
    //}

    class ALComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return (int)x - (int)y;
        }
    }
}
