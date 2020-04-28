using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Geometric
    {
        private double side1;
        private double side2;
        
        public Geometric(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public double Side1
        {
            get => side1;
            set => side1 = value;
        }

        public double Side2
        {
            get => side2;
            set => side2 = value;
        }

        public abstract double CalculatorArea();

        public abstract double CalculatorPrimeter();


        public virtual string ShowInfo()
        {
            return $"Side 1 : {side1}, Side 2: {side2}";
        }
    }

    class Rectangle : Geometric
    {
        public Rectangle(double l, double w) : base(l, w)
        {
        }
        public override double CalculatorArea()
        {
            return Side1* Side2;
        }

        public override double CalculatorPrimeter()
        {
            return (Side1 + Side2) *2;
        }

        public override string ShowInfo()
        {
            return $"Length : {Side1}, Width : {Side2}"; ;
        }
    }

    class Circle : Geometric
    {
        //private const double Pi = Math.PI;
        //private double radius;

        public Circle(double r) : base(r, Math.PI)
        {
        }

        public override double CalculatorArea()
        {
            return Side2 * Side1 * Side1;
        }

        public override double CalculatorPrimeter()
        {
            return 2 * Side2 * Side1;
        }
    }

    class Square : Geometric
    {
        public Square(double l) : base(l, l)
        {

        }
        public override double CalculatorArea()
        {
            return Side1 * Side1;
        }
        public override double CalculatorPrimeter()
        {
            return 4 * Side1;
        }
    }
}
