using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle()
        {
        }

        public Rectangle(double side1, double side2): base(side1, side2)
        {
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public double GetArea( double w, double h)
        {
            return width * length;
        }

        public double GetPerimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            return "A Rectangle with width="
                    + getWidth()
                    + " and length="
                    + getLength()
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }
    }
