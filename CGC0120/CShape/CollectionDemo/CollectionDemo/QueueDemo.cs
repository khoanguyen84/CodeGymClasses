using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo.QueueDemo
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            for(int i=0; i <10;i++)
            {
                q.Enqueue(i + 1);
            }

            while(q.Count > 0)
            {
                Console.WriteLine(q.Peek());
                q.Dequeue();
            }
        }
    }
}
