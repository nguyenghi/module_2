using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {  private double a,b,c;
     public QuadraticEquation(double a,double b,double c)
     {
         this.a = a;
         this.b = b;
         this.c = c;

     }
     public string Getter(){
         return "( a =" +this.a + ", b ="+ this.b +", c ="+ this.c +")" ;
     }
     public double GetDiscriminant()
     {
        double delta;
        delta = b*b -4*a*c;
        return delta;
     }
     public double  GetRoot1( double delta)
     {
         double root1;
         root1 = (-b + Math.Sqrt(delta) )/(2*a);
         return root1;
     }
    public double  GetRoot2( double delta)
     {
         double root2;
         root2 = (-b - Math.Sqrt(delta) )/(2*a);
         return root2;
     }

     

     

    }
}