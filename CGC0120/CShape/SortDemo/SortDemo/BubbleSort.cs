using System;
using System.Collections.Generic;
using System.Text;

namespace SortDemo
{
    class BubbleSort
    {
        public void SortDown(ref int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine($"----i = {i}-----");
                for(int j = 0; j< arr.Length - i; j++)
                {
                    Console.WriteLine($"j = {j}");
                    if (arr[j] > arr[j+1])
                    {
                        Helper.Swrap(ref arr[j], ref arr[j+1]);
                    }
                }
                Console.WriteLine($"---------------");
            }
        }

        public void SortUpgrade(ref int[] arr)
        {
            bool neededToSort = true;
            for (int i = 1; i < arr.Length && neededToSort; i++)
            {
                Console.WriteLine($"----i = {i}----");
                neededToSort = false;
                for (int j = 0; j < arr.Length - i; j++)
                {
                    Console.WriteLine($"j = {j}");
                    if (arr[j] > arr[j + 1])
                    {
                        Helper.Swrap(ref arr[j], ref arr[j + 1]);
                        neededToSort = true;
                    }
                }
                Console.WriteLine($"---------------");
            }
        }

        public void SortUp(ref int[] arr)
        {
            for (int i = arr.Length; i >= 1 ; i--)
            {
                for (int j = arr.Length - i; j >=0 ; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Helper.Swrap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

        public string ShowArray(int[] arr)
        {
            string str = "";
            for(int i=0; i< arr.Length; i++)
            {
                str = $"{str} {arr[i]}";
            }
            return str;
        }
    }
}
