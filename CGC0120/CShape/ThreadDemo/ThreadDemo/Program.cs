using System;
using System.Text;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine("Process 1");
            //Thread thread1 = new Thread(Process1);
            Process1();
            //Console.WriteLine("Process 2");
            //Thread thread2 = new Thread(Process2);
            //thread2.Priority = ThreadPriority.Highest;
            //thread1.Priority = ThreadPriority.Lowest;
            //Process2();
            //thread1.Start();
            
            //thread2.Start();
            //Console.WriteLine("Waiting 1000 millisecond");
            //Thread.Sleep(100000);
            //thread2.Join();
            //Thread.Yield();
            Console.WriteLine("Commpleted.");
            
        }

        public static void Process1()
        {
            var startTime = DateTimeOffset.Now;
            for (int i = 0; i < 500000; i++)
            {
                Console.WriteLine($"1. {i + 1}, Time: {DateTimeOffset.Now.ToString("dd/MM/yyyy hh:mm:ss fff tt")}");
            }
            var endTime = DateTimeOffset.Now;
            Console.WriteLine($"Total time : {(endTime - startTime).TotalSeconds}");
        }

        public static void Process2()
        {
            for (long i = 20; i < long.MaxValue; i++)
            {
                Console.WriteLine($"2. {i + 1}, Time: {DateTimeOffset.Now.ToString("dd/MM/yyyy hh:mm:ss fff tt")}");
            }
        }
    }
}
