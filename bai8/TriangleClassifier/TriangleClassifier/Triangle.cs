using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleClassifier
{
    public class Triangle
    {
        private double side1 { get; set; }
        private double side2{ get; set; }
        private double side3{ get; set; }
        public  double Side1
        {
            get => side1;
            set => side1 = value;
        }
        public double Side2
        {
            get => side1;
            set => side1 = value;
        }
        public double Side3
        {
            get => side1;
            set => side1 = value;
        }



        public bool IsTriagle(double side1,double side2, double side3)
        {
            bool flag = false;
            if( side1 >0 && side2 >0 && side3> 0)
            {
               if(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    flag = true;
                } 
            }
            return flag;
        }
         public string IsoscelesTriagle(double side1, double side2, double side3)
            
        {
            if (side1 == side2 || side2 == side3 || side3 == side1)
            {
                return " Is a isosceles triangle";


            }
            return "Is not a isosceles triangle ";







        }
        public string IsEquilateralTriagle(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "is a equilateral triagle";
            }
            return "is not a equilateral triagle";
        }
    }
}
