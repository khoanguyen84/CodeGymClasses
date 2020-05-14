using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TryCatchDemo
{
    class IOFileDemo
    {
        public static void Main()
        {
            string path = @$"C:\CodeGym\Classes\CGC0120\CShape\{DateTime.Now.ToString("dd_MM_yyyy")}.txt";
            ////File.Create(path);
            //File.CreateText(path);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("Everyone at C0220");
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("We are learning NET CORE");
                sw.WriteLine("We are one");
            }

            FileInfo fileInfo = new FileInfo(path);
            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine("Write by FileInfo");
            }

            FileStream fileStream = new FileStream(path, FileMode.Append);
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                sw.WriteLine("Write by FileStream");
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                };
            }


            
        }
    }
}
