using System;
using Services.JsonDemo;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"C:\CodeGym\Classes\CGC0120\CShape\JsonDemo\JsonDemo\Data\input.json";
            string outputPath = @"C:\CodeGym\Classes\CGC0120\CShape\JsonDemo\JsonDemo\Data\output.json";
            var jsonService = new JsonService(inputPath, outputPath);
            jsonService.ReadJson();
            jsonService.WriteJson();
        }
    }
}
