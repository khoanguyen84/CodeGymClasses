using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileDemo
{
    class FileStreamDemo
    {
        public static void Main()
        {
            string pathInput = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\input.txt";
            FileStream fileStream = new FileStream(pathInput, FileMode.OpenOrCreate);
            using (StreamReader sr = new StreamReader(fileStream))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}
