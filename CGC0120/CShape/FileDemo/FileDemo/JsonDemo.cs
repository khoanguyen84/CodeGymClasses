using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace FileDemo
{
    class JsonDemo
    {
        public static string path = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\db.json";
        public static string outPath = @"C:\CodeGym\Classes\CGC0120\CShape\FileDemo\FileDemo\Files\newdb.json";
        public static void Main()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                var json = sr.ReadToEnd();
                var data = JsonConvert.DeserializeObject<Payload>(json);
                foreach (var film in data.films)
                {
                    Console.WriteLine(film.ToString());
                }

                foreach (var user in data.users)
                {
                    Console.WriteLine(user.ToString());
                }
            }

            Payload newData = new Payload()
            {
                films = new List<Films>()
                {
                    new Films()
                    {
                        id = 1,
                        poster = "abd",
                        title = "def",
                        shortDesc = "fgfgd"
                    },
                    new Films()
                    {
                        id = 2,
                        poster = "abd",
                        title = "def",
                        shortDesc = "fgfgd"
                    },
                },
                users = new List<Users>()
                {
                    new Users()
                    {
                        id = 1,
                        email = "sf@sdgdf.com",
                        password = "w4545"
                    }
                }
            };

            using (StreamWriter sw = File.CreateText(outPath))
            {
                var obj = JsonConvert.SerializeObject((object)newData);
                sw.WriteLine(obj);
            }
        }
    }

    class Payload
    {
        public List<Films> films { get; set; }
        public List<Users> users { get; set; }
    }

    public class Films
    {
        public int id { get; set; }
        public string poster { get; set; }
        public string title { get; set; }
        public string shortDesc { get; set; }

        public override string ToString()
        {
            return $"Id : {id}, " +
                $"Poster: {poster.Substring(0, 10)}, " +
                $"Title: {title.Substring(0, 10)}, " +
                $"ShortDesc: {shortDesc.Substring(0, 10)}";
        }
    }

    class Users
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
