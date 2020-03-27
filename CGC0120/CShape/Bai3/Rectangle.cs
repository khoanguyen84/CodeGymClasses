using System;

namespace C0120
{
    class Rectangle
    {
        // cac bien thanh vien
        double length;
        double width;

        //phuong thuc
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        //phuong thuc
        public double GetArea()
        {
            return length * width;
        }

        //phuong thuc
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
    }
}