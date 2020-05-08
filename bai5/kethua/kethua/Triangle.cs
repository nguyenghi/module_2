using System;
using System.Collections.Generic;
using System.Text;

namespace triangle
{
     public class Triangle : Shape

    {
        protected double side1 = 1.0;
        protected double side2 = 1.0;
        protected double side3 = 1.0;
        public Triangle()
        {

        }
        public Triangle ( double side1, double side2, double side3, string color, bool filled): base(color,filled)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

        }
        public double Side1
        {
            get => this.side1;
            set => side2 = value;
        }
        public double Side2
        {
            get => this.side2;
            set => side2 = value;
        }
        public double Side3
        {
            get => this.side3;
            set => side3 = value;
        }
        public double GetPrimeter()
        {
            double pri = this.side1 + this.side2 + this.side3;
            return pri;
        }
        public double GetArea()
        {
            double p = GetPrimeter() / 2;
            double area = Math.Sqrt(p * (p - this.side1) * (p - this.side2) * (p - this.side3));
            return area;
        }
        public override string ToString()
        {
            return $" A Triangle  with color {GetColor()}\n Side1 =  {side1}\n Side2= {side2}\n Side3= {side3}\n Area= {GetArea()}\n Primer= {GetPrimeter()}";
        }
    }
}
