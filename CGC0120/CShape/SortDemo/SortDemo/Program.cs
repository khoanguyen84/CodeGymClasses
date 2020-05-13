using System;

namespace SortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 6, 9, 2, 8, 5, 7, 10, 45, 23, 34, 1, 3, 7, 90, 23 };
            //BubbleSort bubbleSort = new BubbleSort();
            //Console.WriteLine("-----------Before Sort-------------");
            //Console.WriteLine(bubbleSort.ShowArray(arr));
            //Console.WriteLine("-----------before upgrade-------------");
            //bubbleSort.SortDown(ref arr);
            //Console.WriteLine(bubbleSort.ShowArray(arr));

            //int[] arr1 = new int[] { 6, 9, 2, 8, 5, 7, 10, 45, 23, 34, 1, 3, 7, 90, 23 };
            //Console.WriteLine("-----------after upgrade-------------");
            //bubbleSort.SortUpgrade(ref arr1);
            //Console.WriteLine(bubbleSort.ShowArray(arr1));
            try
            {
                A a = new A();
                a.AM();
            }
            catch (TryCatchDemo e)
            {
                Console.WriteLine($"{e.GetType().Name}: {e.Message}");

            }
            

            try
            {

            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            
        }


        class A
        {
            public void AM()
            {
                B b = new B();
                b.BM();
            }
        }

        class B
        {
            public void BM()
            {
                C c = new C();
                c.Check();
            }
        }

        class C
        {
            public void Check()
            {
                int a = 6;
                if (a != 5)
                    throw new TryCatchDemo(a);
            }
        }
    }
}
