using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Models
{
    class Order
    {
        public string tableNo { get; set; }
        public bool paid { get; set; }
        public string starttime { get; set; }
        public List<OrderDetail> orderdetails { get; set; }
    }
}
