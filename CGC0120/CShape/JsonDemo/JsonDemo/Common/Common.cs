using System;
using System.Collections.Generic;
using System.Text;

namespace JsonDemo.Common
{
    struct Rank
    {
        public const double XuatSac = 9.0;
        public const double Gioi = 8.0;
        public const double Kha = 7.0;
        public const double TBK = 6.5;
        public const double TB = 5.0;
        public const double Yeu = 3.5;

        public override string ToString()
        {
            return base.ToString();
        }

        public static string ToString(double rank = 3.4)
        {
            switch (rank)
            {
                case XuatSac:
                    {
                        return "Xuất sắc";
                    }
                case Gioi:
                    {
                        return "Giỏi";
                    }
                case Kha:
                    {
                        return "Khá";
                    }
                case TBK:
                    {
                        return "TBK";
                    }
                case TB:
                    {
                        return "TB";
                    }
                case Yeu:
                    {
                        return "Yếu";
                    }
                default:
                    {
                        return "Kém";
                    }
            }
        }
    }
}
