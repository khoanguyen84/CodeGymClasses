using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Ca : IBoi
    {
        public string BoiNhuTheNao()
        {
            return "Boi bang vay";
        }
    }

    class Duck: IBoi
    {
        public string BoiNhuTheNao()
        {
            return "Boi bang chan";
        }

    }

    class Boat : IBoi
    {
        public string BoiNhuTheNao()
        {
            return "Boi bang dong co";
        }
    }

    interface IBoi
    {
        string BoiNhuTheNao();
    }
}
