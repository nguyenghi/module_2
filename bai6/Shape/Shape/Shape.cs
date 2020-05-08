using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Shape
{
     public class Shape
    {
        protected string color = " green";
        protected bool filled = true;
        protected double side1 { get; set; }
        protected double side2 { get; set; }

        public Shape()
        {

        }
        public Shape(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public String GetColor()
        {

            return color;

        }
        public void SetColor(String color)
        {

            this.color = color;

        }
        public bool IsFilled()
        {

            return filled;

        }
        public void SetFilled(bool filled)
        {

            this.filled = filled;

        }
       
        public double GetArea()
        {
            return side1 * side2;
        }
        public override String ToString()
        {

            return "A Shape with color of "
                    + GetColor()
                    + " and "
                    + (IsFilled() ? "filled" : "not filled");

        }
    }
}
