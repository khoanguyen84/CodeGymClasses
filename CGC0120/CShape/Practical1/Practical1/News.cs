using System;
using System.Collections.Generic;
using System.Text;

namespace Practical1
{
    class News : INews
    {
        private int id;
        private string title;
        private DateTime publishDate;
        private string author;
        private string content;
        private float avarageRate;
        public int[] RateList = new int[3];

        public News()
        {

        }
        public int ID 
        { 
            get => id; 
            set => id = value; 
        }
        public string Title 
        { 
            get => title; 
            set => title = value; 
        }
        public DateTime PublishDate 
        { 
            get => publishDate; 
            set => publishDate = value; 
        }
        public string Author 
        { 
            get => author; 
            set => author = value; 
        }
        public string Content 
        { 
            get => content; 
            set => content = value; 
        }

        public float AverageRate
        {
            get => avarageRate;
        }


        public void Display()
        {
            Console.WriteLine($"Id: {id}\t" +
                                $"Title: {title}\t" +
                                $"Publish date: {publishDate.ToString("dd/MM/yyyy")}\t" +
                                $"Author: {author}\t" +
                                $"Content: {Content}\t" +
                                $"Average rate: {avarageRate}");
        }

        public void Calculate()
        {
            float total = 0;
            foreach(float item in RateList)
            {
                total += item;
            }
            avarageRate = total / RateList.Length;
        }
    }
}
