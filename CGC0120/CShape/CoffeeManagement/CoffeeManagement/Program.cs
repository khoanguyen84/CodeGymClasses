using CoffeeManagement.Models;
using CoffeeManagement.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;

namespace CoffeeManagement
{
    class Program
    {
        public static string dataPath = @"C:\CodeGym\Classes\CGC0120\CShape\CoffeeManagement\CoffeeManagement\Data\order.json";
        public static string billPath = @"C:\CodeGym\Classes\CGC0120\CShape\CoffeeManagement\CoffeeManagement\Data\";
        public static BillService billService = new BillService(dataPath, billPath);
        static void Main(string[] args)
        {
            CreateMenu();
        }
        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("COFFEE MANAGEMENT");
                Console.WriteLine("Please select an option from 1 to 4:");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Update Order");
                Console.WriteLine("3. Print Bill");
                Console.WriteLine("4. Exit");
                Console.Write("option: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 4 || option < 1);

            Process(option);
        }

        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        AddOrder();
                        break;
                    }
                case 2:
                    {
                        UpdateOrder();
                        break;
                    }
                case 3:
                    {
                        PrintBill();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }

        public static void AddOrder()
        {
            
            Console.Write("Enter table number: ");
            var tableNo = Console.ReadLine();
            var foundTable = billService.FindTable(tableNo, out int pos);
            if(pos != -1)
            {
                Console.WriteLine("Table is using, please try with other table");
            }
            else
            {
                var order = new Order()
                {
                    orderdetails = new List<OrderDetail>()
                };
                order.tableNo = tableNo;
                order.paid = false;
                order.starttime = DateTime.Now.ToString("hh:mm tt dd/MM/yyyy");

                string option = "n";
                do
                {
                    var orderDetail = new OrderDetail();
                    Console.Write("Enter name: ");
                    orderDetail.name = Console.ReadLine();
                    Console.Write("Enter count: ");
                    orderDetail.count = Console.ReadLine();
                    Console.Write("Enter price: ");
                    orderDetail.price = Console.ReadLine();
                    order.orderdetails.Add(orderDetail);
                    Console.WriteLine("COFFEE MANAGEMENT");
                    Console.Write("Do you want to continue? (y/n): ");
                    option = Console.ReadLine();
                }
                while (option != "n");
                billService.AddOrder(order);
            }
        }

        public static void UpdateOrder()
        {

            Console.Write("Enter table number: ");
            var tableNo = Console.ReadLine();
            var foundTable = billService.FindTable(tableNo, out int pos);
            if (pos == -1)
            {
                Console.WriteLine("Table is not using, please try with other table.");
            }
            else
            {
                var orderdetails = new List<OrderDetail>();

                string option = "n";
                do
                {
                    var orderDetail = new OrderDetail();
                    Console.Write("Enter name: ");
                    orderDetail.name = Console.ReadLine();
                    Console.Write("Enter count: ");
                    orderDetail.count = Console.ReadLine();
                    Console.Write("Enter price: ");
                    orderDetail.price = Console.ReadLine();
                    orderdetails.Add(orderDetail);
                    Console.WriteLine("COFFEE MANAGEMENT");
                    Console.Write("Do you want to continue? (y/n): ");
                    option = Console.ReadLine();
                }
                while (option != "n");
                billService.UpdateOrder(tableNo, orderdetails, false);
            }
        }

        public static void PrintBill()
        {
            Console.Write("Enter table number: ");
            var tableNo = Console.ReadLine();
            var foundTable = billService.FindTable(tableNo, out int pos);
            if (pos == -1)
            {
                Console.WriteLine("Table is not using, please try with other table.");
            }
            else
            {
                billService.PrintBill(tableNo);
                Console.WriteLine($"Bill printed for table {tableNo}");
            }
        }
    }
}
