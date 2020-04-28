using System;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human();
            //human.Name = "Khoa";

            //Human.Asian asian = new Human.Asian();
            //asian.Name = "Trung";
            //asian.SkinColor = "Yellow";

            //Person person = new Person("Khoa", "28 NTP");
            //Console.WriteLine(person.ToString());
            //Console.WriteLine(person.Sologen());

            //Staff staff = new Staff("Khoa", "khoa.nguyen@codegym.vn", "28 NTP");
            //staff.BackAccount = "123-456-7890";
            //Console.WriteLine(staff.ToString());

            
            //Staff p = (Staff)person;

            double a = 5.5;

            int b = (int)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(person.Sologen());

            //Manager ghi = new Manager("Ghi", "ghi.nguyen@codegym.vn", "28 NTP", "Training");
            //ghi.BackAccount = "222-333-4444";
            //Console.WriteLine(ghi.ToString());

            //Animal dog = new Animal();
            Console.ReadKey();
        }
    }
}
