using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileDemo
{
    class DirectoryDemo
    {
        public static string path = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo";
        public static void Main()
        {
            Directory.CreateDirectory($@"{path}\A\B");
            //Directory.Delete("");
            Directory.Move($@"{path}\A", $@"{path}\D");
            //Directory.Exists()
        }
    }
}
