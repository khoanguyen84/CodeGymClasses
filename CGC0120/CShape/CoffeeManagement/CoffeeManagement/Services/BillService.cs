using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CoffeeManagement.Models;
using CoffeeManagement.Ultility;
using Newtonsoft.Json;

namespace CoffeeManagement.Services
{
    class BillService
    {
        private string dataPath;
        private string billPath;

        private OrderData orderData;

        public BillService(string _dataPath, string _billPath)
        {
            orderData = new OrderData()
            {
                orders = new List<Order>()
            };
            dataPath = _dataPath;
            billPath = _billPath;
            ReadData();
        }

        public void ReadData()
        {
            using (StreamReader sr = File.OpenText(dataPath))
            {
                var obj = sr.ReadToEnd();
                orderData = JsonConvert.DeserializeObject<OrderData>(obj);
            }
        }

        public void WriteData()
        {
            using (StreamWriter sw = File.CreateText(dataPath))
            {
                var json = JsonConvert.SerializeObject(orderData);
                sw.WriteLine(json);
            }
        }

        public void AddOrder(Order order)
        {
            var foundTable = FindTable(order.tableNo, out int pos);
            if(foundTable == null)
            {
                orderData.orders.Add(order);
                WriteData();
            }
        }

        public void UpdateOrder(string tableNo, List<OrderDetail> orderdetails = null, bool isPaid = false)
        {
            var foundTable = FindTable(tableNo, out int pos);
            if (foundTable != null)
            {
                if (isPaid)
                {
                    orderData.orders[pos].paid = isPaid;
                }
                else
                {
                    foreach (var detail in orderdetails)
                    {
                        orderData.orders[pos].orderdetails.Add(detail);
                    }
                }
            }
            WriteData();
        }

        public Bill ProcessBill(string tableNo)
        {
            var foundTable = FindTable(tableNo, out int pos);
            if(foundTable != null)
            {
                var bill = new Bill()
                {
                    endtime = DateTime.Now.ToString("hh:mm tt dd/MM/yyyy"),
                    starttime = foundTable.starttime,
                    tableNo = foundTable.tableNo
                };
                bill.orderdetails = new List<OrderDetail>();
                foreach(var detail in foundTable.orderdetails)
                {
                    bill.orderdetails.Add(new OrderDetail()
                    {
                        count = detail.count,
                        money = detail.CalculatorMoney().ToString(),
                        name = detail.name,
                        price = detail.price,
                    });
                }
                return bill;
            }
            return null;
        }

        public bool PrintBill(string tableNo)
        {
            try
            {
                var bill = ProcessBill(tableNo);
                if (bill != null)
                {
                    string fileName = $"bill_{tableNo}_{DateTime.Now.ToString("yyyyMMddhhmm")}.json";
                    using (StreamWriter sw = File.CreateText($"{billPath}{fileName}"))
                    {
                        var billData = JsonConvert.SerializeObject(bill);
                        sw.WriteLine(billData);
                    }
                    UpdateOrder(tableNo, null, true);
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public Order FindTable(string tableNo, out int position)
        {
            position = -1;
            if(orderData != null && orderData.orders != null)
            {
                foreach (var order in orderData.orders)
                {
                    if (order.tableNo.Equals(tableNo) && !order.paid)
                    {
                        position = orderData.orders.IndexOf(order);
                        return order;
                    }
                }
            }
            return null;
        }
    }
}
