using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileDemo
{
    class FileInfoDemo
    {
        public static void Main()
        {
            string pathInput = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\input.txt";
            FileInfo fileInfo = new FileInfo(pathInput);
            using (StreamReader sr = fileInfo.OpenText())
            {
                string line = "";
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
