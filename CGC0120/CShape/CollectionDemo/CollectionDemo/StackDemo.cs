using System;
using System.Collections;
using System.Text;

namespace CollectionDemo.StackDemo
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            for(int i = 0; i< 10; i++)
            {
                s1.Push(i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(s1.Pop());
            }
        }
    }
}
