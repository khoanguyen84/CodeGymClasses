using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagement.Models
{
    class Bill
    {
        public string tableNo { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public string total => SumTotal();
        public List<OrderDetail> orderdetails { get; set; }

        public string SumTotal()
        {
            long sum = 0;
            foreach(var item in orderdetails)
            {
                sum += long.Parse(item.money);
            }
            return sum.ToString();
        }
    }
}
