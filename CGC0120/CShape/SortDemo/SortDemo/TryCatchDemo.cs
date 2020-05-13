using System;
using System.Collections.Generic;
using System.Text;

namespace SortDemo
{
    class TryCatchDemo : Exception
    {
        private int isAPrime;
        public TryCatchDemo() : base()
        {

        }

        public TryCatchDemo(int value) : base($"{value} not a prime")
        {
            isAPrime = value;
        }

        public int IsAPrime
        {
            get => isAPrime;
        }
    }
}
