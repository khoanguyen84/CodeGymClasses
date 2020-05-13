using System;

namespace SearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[] { 5,7,3,4,9,10,23,12,15,6,4,9 };
            //Console.Write("Input your value = ");
            //int value = int.Parse(Console.ReadLine());
            //int pos = LinearSearch(arr1, value);
            //if (pos > -1)
            //{
            //    Console.WriteLine($"your value {value} stand at {pos} in array");
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            Console.Write("Input n = ");
            long n = long.Parse(Console.ReadLine());
            //Console.WriteLine($"{n}! = {GT(n)}");
            Console.WriteLine($"{n}! = {GT2(n)}");
        }

        static int LinearSearch(int[] arr, int value)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static long GT(long n)
        {
            if(n < 2)
            {
                return 1;
            }
            return n * GT(n - 1);
        }

        static long GT2(long n)
        {
            long gt = 1;
            for(long i = 1; i<= n; i++)
            {
                gt *= i;
            }
            return gt;
        }
    }

    class A
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public A()
        {

        }

        public A(int p1)
        {
            P1 = p1;
        }
    }

    class B : A
    {
        public B() : base()
        {

        }
        public B(int p1) : base(p1)
        {

        }
    }

}
