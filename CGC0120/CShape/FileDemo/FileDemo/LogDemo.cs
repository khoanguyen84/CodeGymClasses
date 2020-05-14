using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileDemo
{
    class LogDemo
    {
        public static void Main()
        {
            string fileName = $"[Error]{DateTime.Now.ToString("dd_MM_yyyy_hh_mm")}.txt";
            string path = @$"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\{fileName}";

            try
            {
                int a = 8;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch(Exception e)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("hh:mm:ss")}: {e.Message}");
                }
            }
        }
    }
}
