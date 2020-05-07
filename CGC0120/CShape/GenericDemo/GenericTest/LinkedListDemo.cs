using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<Product> products = new LinkedList<Product>();
            products.AddLast(new Product()
            {
                Id = 1,
                Name = "IP8"
            });
        }
    }
}
