using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ThreadDemo
{
    unsafe class StringDemo
    {
        public static void Main()
        {
            string str = "CodeGym";
            string str2 = "Hue";
            Console.WriteLine();
            char c = str[0];
            //str[0] = 'K';
            StringBuilder strb = new StringBuilder(str);
            strb[0] = 'c';

            var pattern = @"\a\";
            Regex regex = new Regex(pattern);

        }
    }
}
