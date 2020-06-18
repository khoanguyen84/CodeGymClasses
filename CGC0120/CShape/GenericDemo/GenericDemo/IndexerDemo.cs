using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GenericDemo
{
    class IndexerDemo<T>
    {
        private T[] list = new T[0];

        public T this[int index]
        {
            get
            {
                T tmp = default(T);
                if(index >=0 && index < list.Length)
                {
                    tmp = list[index];
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index < list.Length)
                {
                    Array.Resize(ref list, list.Length + 1);
                    list[index] = value;
                }
            }
        }

        public void Add(T tmp)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length -1] = tmp;
        }
    }
}
