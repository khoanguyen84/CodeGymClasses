using System;
using System.Collections.Generic;
using System.Text;

namespace SortDemo
{
    public static class Helper
    {
        public static void Swrap(ref int n1, ref int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
    }
}
