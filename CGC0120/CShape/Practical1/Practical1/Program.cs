using System;
using System.Collections;
using System.Collections.Generic;

namespace Practical1
{
    class Program
    {
        //public static Hashtable ListNews = new Hashtable();
        public static SortedList ListNews = new SortedList();
        public static int increment = 1;
        static void Main(string[] args)
        {
            CreateMenu();
        }

        public static void CreateMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("NEWS MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an optional from 1 to 4:");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.Write("option: ");

                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    option = number;
                }
            }
            while (option > 4 || option < 1);

            Process(option);
        }

        public static void Process(int opt)
        {
            Console.Clear();
            switch (opt)
            {
                case 1:
                    {
                        InsertNews();
                        break;
                    }
                case 2:
                    {
                        ViewListNews();
                        break;
                    }
                case 3:
                    {
                        CalculateRate();
                        ViewListNews();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            CreateMenu();
        }

        public static void InsertNews()
        {
            News news = new News();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            DateTime publishDate = DateTime.Now;
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Console.WriteLine("enter rate: ");
            for(int i = 0; i< news.RateList.Length; i++)
            {
                Console.Write($"rate {i+1} = ");
                news.RateList[i] = int.Parse(Console.ReadLine());
            }

            news.Title = title;
            news.Author = author;
            news.Content = content;
            news.PublishDate = publishDate;
            news.ID = increment;
            increment++;

            //ListNews.Add(news.ID, news);
            //ListNews.Add(news);
            ListNews.Add(news.ID, news);
        }

        public static void ViewListNews()
        {
            //foreach(News news in ListNews.Values)
            foreach (News news in ListNews.Values)
            {
                news.Display();
            }
        }

        public static void CalculateRate()
        {
            //foreach (News news in ListNews.Values)
            foreach (News news in ListNews.Values)
            {
                news.Calculate();
            }
        }
    }
}
