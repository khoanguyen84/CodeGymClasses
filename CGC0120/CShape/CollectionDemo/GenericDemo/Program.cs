using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<Student> myGeneric = new MyGeneric<Student>();
            myGeneric.Field = new Student() { 
                                    Fullname = "Khoa Nguyen"
                                };
            Console.WriteLine(myGeneric.ToString());

            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Fullname = "Khoa Nguyen"
                }
            };

            var student = new Student()
            {
                Fullname = "Khoa Nguyen"
            };

            Dictionary<int, Student> std = new Dictionary<int, Student>();
            std.Add(1, new Student() { Fullname = "Khoa Nguyen" });

            foreach(int key in std.Keys)
            {
                std[key].Fullname = "sdf";

            }

            LinkedListNode<Student> linkedListNode = new LinkedListNode<Student>(student);
            LinkedList<Student> std1 = new LinkedList<Student>();
            std1.AddLast(linkedListNode);


        }
    }

    class MyGeneric<T> where T: class
    {
        private T field;
        public MyGeneric()
        {
        }

        public T Field
        {
            get => field;
            set => field = value;
        }
        public override string ToString()
        {
            return $"Type of is {typeof(T).ToString()} and value is {field.ToString()}";
        }
    }

    class Student
    {
        public string Fullname { get; set; }
        public override string ToString()
        {
            return $"{Fullname}";
        }
    }
}
