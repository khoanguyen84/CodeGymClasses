using System;

namespace Bai4
{
    class Demo01
    {
        public static void Main(string[] args)
        {
            string fullname = "";
            int age = 0;
            Console.WriteLine("My first project code on VS Code");
            Console.Write("Please enter your fullname: ");
            fullname =  Console.ReadLine();
            Console.Write("Please enter your age: ");
            // age = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Your name is " + fullname + " and your age is " + age);
            Console.WriteLine(string.Format("Your name is {0} and your age is {1}", fullname, age));
            Console.WriteLine("Your name is {0} and your age is {1}", fullname, age);
            Console.ReadKey();
        }
    }
}