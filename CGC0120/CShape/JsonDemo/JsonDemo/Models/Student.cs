using System;
using System.Collections.Generic;
using System.Text;

namespace JsonDemo.Models
{
    class Student
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string gender { get; set; }
        public string level { get; set; }
        public List<Subject> subjects { get; set; }

        public double AverageScores()
        {
            double total = 0;
            foreach(var subject in subjects)
            {
                total += double.Parse(subject.score);
            }
            return total / subjects.Count;
        }

        public string Rank()
        {
            double averageScore = AverageScores();
            if(averageScore >= Common.Rank.XuatSac)
            {
                return Common.Rank.ToString(Common.Rank.XuatSac);
            }
            else if (averageScore >= Common.Rank.Gioi)
            {
                return Common.Rank.ToString(Common.Rank.Gioi);
            }
            else if(averageScore >= Common.Rank.Kha)
            {
                return Common.Rank.ToString(Common.Rank.Kha);
            }
            else if(averageScore >= Common.Rank.TBK)
            {
                return Common.Rank.ToString(Common.Rank.TBK);
            }
            else if (averageScore >= Common.Rank.TB)
            {
                return Common.Rank.ToString(Common.Rank.TB);
            }
            else if (averageScore >= Common.Rank.Yeu)
            {
                return Common.Rank.ToString(Common.Rank.Yeu);
            }
            else
            {
                return Common.Rank.ToString();
            }
        }
    }
}
