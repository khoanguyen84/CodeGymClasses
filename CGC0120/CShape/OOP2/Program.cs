using System;
using System.Text;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Student minh = new Student();
            minh.SetFullName("Minh Ton");
            minh.Email = "minh.ton@codegym.vn";
            minh.PhoneNumber = "0935123456";
            Console.WriteLine("Iam in class: {0}", Student.className);
            Console.WriteLine("Student fullname : {0}", minh.GetFullName());
            Console.WriteLine("Student email : {0}", minh.Email);
            Console.WriteLine("Student phone number : {0}", minh.PhoneNumber);
            Console.WriteLine("Our class code is : {0}", Student.ClassCode());

            Student tram = new Student("Tram Le");

            Console.WriteLine("Student fullname : {0}", tram.GetFullName());

            Console.Write("Input Tram's score 1: ");
            tram.Score1 = double.Parse(Console.ReadLine());

            Console.Write("Input Tram's score 2: ");
            tram.Score2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Tram's score average : {0}", tram.Average());

            Student trung = new Student("Trung Nguyen", "trung.nguyen@codegym.vn", "0935113113");
            Console.WriteLine("Student fullname : {0}", trung.GetFullName());
            Console.WriteLine("Student email : {0}", trung.Email);
            Console.WriteLine("Student phone number : {0}", trung.PhoneNumber);
            
            trung.Score1 = 8.2;
            trung.Score2 = 7.9;
            Console.WriteLine("Trung's score average : {0}", trung.Average());

            Console.WriteLine("Student fullname : {0}", new Student("Tin Nguyen").GetFullName());
            
        }
    }
}
