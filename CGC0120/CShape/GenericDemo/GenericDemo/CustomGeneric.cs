using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            Customer emps = new Customer();
            foreach(Employee e in emps)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class Customer : IEnumerable
    {
        private Employee[] ts;
        public Customer()
        {
            ts = new Employee[]
            {
                new Employee()
                {
                    EmployeeId = 1,
                    Name ="Khoa Nguyen"
                },
                new Employee()
                {
                    EmployeeId = 2,
                    Name ="Khoa Nguyen"
                },
                new Employee()
                {
                    EmployeeId = 3,
                    Name ="Khoa Nguyen"
                }
            };
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(ts);
        }

        private class MyEnumerator : IEnumerator
        {
            public Employee[] customers;
            int position = -1;

            public MyEnumerator(Employee[] customers)
            {
                this.customers = customers; 
            }

            public object Current
            {
                get
                {
                    try
                    {
                        return customers[position];
                    }

                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
            public bool MoveNext()
            {
                position++;
                return (position < customers.Length);
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}
