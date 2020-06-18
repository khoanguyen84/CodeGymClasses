using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Models
{
    class OrderDetail
    {
        public string name { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public string money { get; set; }

        public long CalculatorMoney()
        {
            return long.Parse(price) * int.Parse(count);
        }
    }
}
