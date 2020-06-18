using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StringRegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C0120G1 CodeGym Hue";
            char c1 = str[0];
            //str[0] = 'c';
            str += "2020";

            String.Concat(str, "2020");

            //char[] dest = new char[50];
            //str.CopyTo(0, dest, 0, 3);

            //Console.WriteLine(string.IsNullOrEmpty(str)? "Yes" : "No");

            string str2 = "";
            string str4 = " ";
            //string str3 = string.Empty;
            //Console.WriteLine(string.IsNullOrEmpty(str2) ? "Yes" : "No");

            string s1 = "code gym";
            string s2 = "code gym";

            Console.WriteLine(string.Compare(s1, s2));
            string.Format("{0}, {1}, {2}", "1", "2", "3");
            string.IsNullOrWhiteSpace(str4);
            int[] arr = { 1, 2, 3, 4, 5 };
            string.Join(",", arr);

            string[] data;
            string str6 = "1,2,3,4,5";
            data = str6.Split(",");


            //foreach(char c in str)
            //{
            //    Console.WriteLine(c);
            //}

            //for(int i = 0; i<str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //StringBuilder sb = new StringBuilder("C0120G1 CodeGym Hue");
            //sb[0] = 'c';

            //Console.WriteLine(str.Substring(16));
            //Console.WriteLine(str.Substring(16,3));

            //string keyword = "CO";
            //keyword = keyword.ToLower();
            //Console.WriteLine(str.ToLower().Contains(keyword) ? "Yes" : "No");
            //str.ToUpper();

            var pattern = @"\w+\";
            Regex regex = new Regex("abd");

        }
    }
}
