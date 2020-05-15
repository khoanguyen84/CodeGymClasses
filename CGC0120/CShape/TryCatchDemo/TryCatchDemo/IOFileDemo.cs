using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace TryCatchDemo
{
    class IOFileDemo
    {
        public static void Main()
        {
            //string path = @$"C:\CodeGym\Classes\CGC0120\CShape\{DateTime.Now.ToString("dd_MM_yyyy")}.txt";
            string pathJSON = @"C:\CodeGym\Classes\CGC0120\CShape\db.json";
            ////File.Create(path);
            //File.CreateText(path);
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine("Hello");
            //    sw.WriteLine("Everyone at C0220");
            //}

            //using (StreamWriter sw = File.AppendText(path))
            //{
            //    sw.WriteLine("We are learning NET CORE");
            //    sw.WriteLine("We are one");
            //}

            //FileInfo fileInfo = new FileInfo(path);
            //using (StreamWriter sw = fileInfo.AppendText())
            //{
            //    sw.WriteLine("Write by FileInfo");
            //}

            //FileStream fileStream = new FileStream(path, FileMode.Append);
            //using (StreamWriter sw = new StreamWriter(fileStream))
            //{
            //    sw.WriteLine("Write by FileStream");
            //} 

            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    };
            //}

            using (StreamReader sr = new StreamReader(pathJSON))
            {
                var json = sr.ReadToEnd();
                Payload data = JsonConvert.DeserializeObject<Payload>(json);
                foreach(var item in data.films)
                {
                    Console.WriteLine(item.ToString());
                }
                foreach (var item in data.users)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
        }
    }


    class Payload
    {
        public List<Item> films { get; set; }
        public List<User> users { get; set; }
    }

    class Item
    {
        public int id { get; set; }
        public string poster { get; set; }
        public string title { get; set; }
        public string shortDesc { get; set; }

        public override string ToString()
        {
            return $"Id: {id}, Poster: {poster.Substring(0,10)}, Title: {title.Substring(0,10)}, ShortDesc: {shortDesc.Substring(0,10)}";
        }
    }

    class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public override string ToString()
        {
            return $"Id: {id}, Email: {email}, Password: {password}";
        }
    }
}
