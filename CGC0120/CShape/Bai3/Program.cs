using System;

namespace C0120
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh minh hoa tinh huong doi tuong trong C#");
            Console.WriteLine("--------------------------------------------------\n");
            //tao doi tuong Rectangle
            Rectangle r = new Rectangle();
            //goi cac phuong thuc cua doi tuong nay
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
