using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack ts = new Stack();

            //Stack<int> vs = new Stack<int>();

            //Queue queue = new Queue();
            //Queue<string> vs1 = new Queue<string>();

            //vs1.Enqueue("Minh");

            //SortedList<int, Employee> list = new SortedList<int, Employee>();

            //Dictionary<string, Employee> emps = new Dictionary<string, Employee>();

            //LinkedList<Employee> employees = new LinkedList<Employee>();



            MyGeneric<Employee> myGeneric = new MyGeneric<Employee>();
            myGeneric.Add(new Employee() 
                                { 
                                    EmployeeId = 1,
                                    Name = "Khoa"
                                });

            myGeneric.Add(new Employee()
            {
                EmployeeId = 2,
                Name = "Minh"
            });
            myGeneric.Add(new Employee()
            {
                EmployeeId = 3,
                Name = "Trung"
            });

            Console.WriteLine("--------------Print--------");
            foreach (var item in myGeneric.MG)
            {
                Console.WriteLine(item.ToString());
            }

            //var empRemove = myGeneric.MG[1];

            //myGeneric.Remove(empRemove);
            //Console.WriteLine("--------------Remove--------");
            //foreach (var item in myGeneric.MG)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //myGeneric.RemoveAt(0);
            //Console.WriteLine("--------------RemoveAt--------");
            //foreach (var item in myGeneric.MG)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //myGeneric.Update(0, new Employee()
            //{
            //    EmployeeId = 1,
            //    Name = "Tram"
            //});
            myGeneric.Update(myGeneric.MG[0], new Employee()
            {
                EmployeeId = 1,
                Name = "Tram"
            });

            Console.WriteLine("--------------Print after update--------");
            foreach (var item in myGeneric.MG)
            {
                Console.WriteLine(item.ToString());
            }

            IndexerDemo<Employee> demo = new IndexerDemo<Employee>();
            demo[0] = new Employee()
            {
                EmployeeId = 1,
                Name = "Khoa"
            };

            demo.Add(new Employee()
            {
                Name = "Khoa",
                EmployeeId = 2
            });
        }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"EmployeeId = {EmployeeId}, Name = {Name}";
        }

        public override bool Equals(object obj)
        {
            return EmployeeId == ((Employee)obj).EmployeeId && Name == ((Employee)obj).Name;
        }
    }
}
