using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class FastFood : Food, IEdible, IDrink//SoftDrink
    {

        public FastFood(string n, double w) : base(n, w)
        {

        }

        public string HowToEat()
        {
            return "a";
        }

        public string HowToDrink()
        {
            return "b";
        }
    }


    class Food
    {
        private string name;
        private double weight;

        public Food(string n, double w)
        {
            name = n;
            weight = w;
        }
    }

    class SoftDrink
    {
        private string name;
        private double price;

        public SoftDrink(string n, double p)
        {
            name = n;
            price = p;
        }
    }
}
