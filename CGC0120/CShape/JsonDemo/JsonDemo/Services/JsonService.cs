using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using JsonDemo.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonDemo.Ultility;

namespace Services.JsonDemo
{
    class JsonService
    {
        private string input;
        private string output;
        private Payload payload;
        private Result result;
        public JsonService(string input, string output)
        {
            this.input = input;
            this.output = output;
        }

        public void ReadJson()
        {
            payload = new Payload() {
                students = new List<Student>()
            };
            using (StreamReader sr = File.OpenText(this.input))
            {
                var obj = sr.ReadToEnd();
                payload = JsonConvert.DeserializeObject<Payload>(obj);
            }
        }

        public void WriteJson()
        {
            ProcessData();
            using (StreamWriter sw = File.CreateText(this.output))
            {
                var data = JsonConvert.SerializeObject(result.results);
                sw.Write(data);
            }
        }

        public void ProcessData()
        {
            result = new Result() {
                results = new List<Response>()
            };
            foreach(var item in payload.students)
            {
                var res = new Response()
                {
                    id = item.id,
                    name = item.fullName,
                    gender = bool.Parse(item.gender) ? "Nam" : "Nữ",
                    level = item.level,
                    averageScore = item.AverageScores(),
                    rank = item.Rank()
                };
                result.results.Add(res);
            }

            result.results.Sort(new CustomSort());
        }
    }
}
