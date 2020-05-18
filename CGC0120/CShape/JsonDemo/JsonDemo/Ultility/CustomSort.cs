using JsonDemo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace JsonDemo.Ultility
{
    class CustomSort : IComparer<Response>
    {
        public int Compare([AllowNull] Response x, [AllowNull] Response y)
        {
            if (x.averageScore < y.averageScore)
            {
                return 1;
            }
            else if (x.averageScore == y.averageScore)
            {
                return 0;
            }
            else
                return -1;
        }
    }
}
