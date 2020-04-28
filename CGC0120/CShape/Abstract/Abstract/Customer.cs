using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public Address DiaChi { get; set; }

        public string DC => $"{DiaChi.SoNha} {DiaChi.TenDuong}, {DiaChi.PhuongXa}";
    }

    class Address 
    {
        public string SoNha { get; set; }
        public string TenDuong { get; set; }
        public string PhuongXa { get; set; }
    }
}
