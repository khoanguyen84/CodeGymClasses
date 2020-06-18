using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DraftDemo
{
    class FileJson
    {
        public static void Main()
        {
            string path = @"C:\CodeGym\Classes\CGC0120\CShape\DraftDemo\DraftDemo\Data\data.json";
            using (StreamReader sw = File.OpenText(path))
            {
                var data = sw.ReadToEnd();
                var payload = JsonConvert.DeserializeObject<Payload>(data);
                foreach(var item in payload.matrix)
                {
                    for(int i=0; i<item.Length; i++)
                    {
                        Console.Write($"{item[i]} ");
                    }
                    Console.WriteLine();
                }
            }

            string path2 = @"C:\CodeGym\Classes\CGC0120\CShape\DraftDemo\DraftDemo\Data\student.json";
            using (StreamReader sw = File.OpenText(path2))
            {
                var data = sw.ReadToEnd();
                var payload = JsonConvert.DeserializeObject<Data>(data);
                Console.WriteLine($"Id\t\tFullName\t\tGender");
                foreach (var student in payload.students)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }

    class Payload
    {
        public List<int[]> matrix { get; set; }
    }

    class Data
    {
        public List<Student> students { get; set; }
    }

    class Student
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public bool gender { get; set; }
        public override string ToString()
        {
            return $"{id}\t\t{fullName}\t\t{(gender ? "Nam" : "Nu")}";
        }
    }
}
