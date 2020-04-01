using System;

namespace Bai4
{
    class Demo02
    {
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine("My second project code on VS Code");
        //     Console.ReadKey();
        // }

        public static void Main(string[] args)
        {
            int total = Add(5, 7);
            Console.WriteLine(total);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}