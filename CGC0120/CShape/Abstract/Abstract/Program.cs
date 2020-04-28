using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geometric geometric = new Geometric();

            //Rectangle rectangle = new Rectangle(20.5, 30.7);
            //Console.WriteLine("Rectangle");
            //Console.Write($"Primeter : {rectangle.CalculatorPrimeter()}");
            //Console.WriteLine();
            //Console.Write($"Area: {rectangle.CalculatorArea()}");
            //Console.WriteLine(rectangle.ShowInfo());

            //Console.WriteLine("Circle");
            //Circle circle = new Circle(15.5);
            //Console.Write($"Primeter : {circle.CalculatorPrimeter()}");
            //Console.WriteLine();
            //Console.Write($"Area: {circle.CalculatorArea()}");
            //Console.WriteLine(circle.ShowInfo());


            //Console.WriteLine("Square");
            //Square  square = new Square(27.5);
            //Console.Write($"Primeter : {square.CalculatorPrimeter()}");
            //Console.WriteLine();
            //Console.Write($"Area: {square.CalculatorArea()}");
            //Console.WriteLine(square.ShowInfo());


            Customer khoa = new Customer()
            {
                CustomerID = 1,
                Name = "Khoa Nguyễn",
                DiaChi = new Address()
                {
                    PhuongXa = "Tây Lộc",
                    SoNha = "39",
                    TenDuong = "Đạm Phương"
                }
            };

            Console.WriteLine(khoa.DC);
            Console.ReadKey();
        }
    }
}
