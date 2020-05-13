using System;
using System.Collections.Generic;

namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vs = new List<int>();

            List<Product> products = new List<Product>() { 
                new Product()
                {
                    Id = 1,
                    Name = "IP 6s"
                },
                new Product()
                {
                    Name = "IP 7",
                    Id = 2
                }
            };

            products.Add(new Product() {
                Id = 3,
                Name = "Samsung"
            });

            foreach(var p in products)
            {
                Console.WriteLine(p.ToString());
            }

            
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
