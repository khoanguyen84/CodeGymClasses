using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 2;
            //Emp[] employees = new Emp[count];
            //for(int i = 0; i < count; i++)
            //{
            //    Emp emp = new Emp();
            //    Console.Write("Input employee's name: ");
            //    emp.Name = Console.ReadLine();
            //    Console.Write("Input employee's email: ");
            //    emp.Email = Console.ReadLine();
            //    Console.Write("Input employee's dob: ");
            //    emp.Dob = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Input employee's address: ");
            //    emp.Address = Console.ReadLine();

            //    var phone = emp.phoneNumber;
            //    emp.PhoneNumber = "01234234";

            //    employees[i] = emp;
            //}

            //foreach(var employee in employees)
            //{
            //    Console.WriteLine(employee.GetInfo());
            //}

            int[] arr = new int[0];
            Array.Resize(ref arr, arr.Length + 1);
            int a = 5;
            Console.WriteLine(a);
            Console.WriteLine(Change(ref a));
            Console.WriteLine(a);

            int outValue = 0;
            int returnValue = 0;
            returnValue = Change2(10, out outValue);
            Console.WriteLine($"returnValue: {returnValue}");
            Console.WriteLine($"outValue: {outValue}");

            int out1;
            int.TryParse("2345", out out1);
        }

        public static int Change(ref int v)
        {
            v += 10;
            return v * v;
        }

        public static int Change2(int n, out int o)
        {
            int v = 0;
            for(int i = 1; i<= n; i++)
            {
                if (i % 5 == 0)
                {
                    v = i;
                    break;
                }
            }
            o = v;
            return v * v;
        }
    }
}
