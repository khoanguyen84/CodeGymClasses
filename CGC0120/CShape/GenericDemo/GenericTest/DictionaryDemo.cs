using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GenericTest
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            products.Add("1234", new Product()
            {
                Id = 1,
                Name = "IP10"
            });

            foreach(var key in products.Keys)
            {
                Console.WriteLine(products[key].ToString());
            }
        }
    }
}
