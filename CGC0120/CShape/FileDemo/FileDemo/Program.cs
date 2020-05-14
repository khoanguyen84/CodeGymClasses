using System;
using System.IO;
namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //File

            string path = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\c0120g1.txt";

            //File.Create(path);
            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //}

            //File.AppendText(path);

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello C0120G1");
                sw.WriteLine("We are learning Net Core");
                sw.WriteLine("CodeGym Hue");
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            //File.AppendText()
        }
    }
}

