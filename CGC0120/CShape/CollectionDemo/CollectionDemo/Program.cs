using System;
using System.Collections;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            al1.Add(1);
            al1.Add(2.4);
            al1.Add('2');
            al1.Add("C0120");
            al1.Add(null);
            al1.Add(2.4);
            al1.Add(new Student()
                        {
                            DoB = DateTime.Parse("2000/10/20"),
                            Fullname = "Khoa Nguyen"
                        });

            //foreach (var item in al1)
            //{
            //    Console.WriteLine(item);
            //}

            //for(int i = 0; i < al1.Count; i++)
            //{
            //    Console.WriteLine(al1[i]);
            //}

            //Console.WriteLine(al1.Capacity);

            //al1.Remove(2.4);
            //al1.RemoveAt(4);

            //foreach (var item in al1)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList al2 = new ArrayList()
            //{
            //    1,4,6,3,7,10,5,9,6,2
            //};

            //al2.Sort();

            //foreach (var item in al2)
            //{
            //    Console.WriteLine(item);
            //}

            ArrayList al3 = new ArrayList()
            {                
                new Student()
                {
                    Fullname = "Tin Nguyen",
                    DoB = DateTime.Parse("10/10/2000")
                },
                new Student()
                {
                    Fullname = "Tram Nguyen",
                    DoB = DateTime.Parse("10/10/2000")
                },
                new Student()
                {
                    Fullname = "Trung Nguyen",
                    DoB = DateTime.Parse("10/10/2000")
                },
                new Student()
                {
                    Fullname = "Minh Ton",
                    DoB = DateTime.Parse("10/10/2000")
                }
            };

            foreach (var item in al3)
            {
                Console.WriteLine(item.ToString());
            }

            al3.Sort(new CustomSort());
            Console.WriteLine("----------------------------------");
            foreach (var item in al3)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Student : Object
    {
        public string Fullname { get; set; }
        public DateTime DoB { get; set; }

        public  override string ToString()
        {
            return $"Fullname: {Fullname}, DoB: {DoB.ToString("dd/MM/yyyy")}";
        }
    }



    class CustomSort : IComparer
    {
        public int Compare(object x, object y)
        {
            return string.Compare(((Student)x).Fullname, ((Student)y).Fullname);
        }

        public int Compare(Student x, Student y)
        {
            return string.Compare(x.Fullname, y.Fullname);
        }
    }
}
