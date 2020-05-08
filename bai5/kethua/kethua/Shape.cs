using System;
using System.Collections.Generic;
using System.Text;

namespace triangle
{
    public class Shape
    {
       protected string color = "green";

       protected  bool filled = true;



        public Shape()

        {

        }



        public Shape(String color, bool filled)

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




        public virtual String ToString()

        {

            return "A Shape with color of "

                    + GetColor()

                    + " and "

                    + (IsFilled() ? "filled" : "not filled");

        }
    }
}
