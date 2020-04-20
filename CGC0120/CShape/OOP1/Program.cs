using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student std = new Student();
            // std.Email = "khoa.nguyen@codegym.vn";
            // Console.WriteLine(std.Email);

            // Student std1 = new Student("Khoa Nguyen", "khoa.nguyen@codegym.vn", "0935216417");
            // Console.WriteLine("My class is {0}", Student.className);
            // Console.WriteLine("Student name: {0},\nemail: {1},\nphone number: {2}", std1.FullName, std1.Email, std1.GetPhoneNumber());


            var packard = new Automobile("Packard", "Custom Eight", 1948);
            Console.WriteLine(packard); // In ra: 1948 Packard Custom Eight

        }
    }
}
