using System;

namespace point2d3d
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D a = new Point2D(3, 4);
            Console.WriteLine(a.ToString());
            Point3D b = new Point3D();
            b.SetXYZ(3, 4, 5);
            Console.WriteLine(b.ToString());


        }
    }
    class Point2D 
    {
      protected float x { get; set; }
      protected float y { get; set; }
     public  Point2D()
     { 
     }
     public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
     public string GetXY()
        {
            return "x " + this.x + "y " + this.y;
        }
    public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    public override string ToString()
        {
            return "( " 
                + this.x 
                +","
                + this.y
                + ")";
           

        }

    }
    class Point3D: Point2D
    {
        private float z { get; set; }
    public Point3D()
        {

        }
    public Point3D(float x, float y, float z): base(x, y) 
        {
            this.z = z;
        }
    public  string GetXYZ()
        {
            return GetXY() + "z" + this.z; 


        }
     public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y);
            this.z = z;


        }
        public override string ToString()
        {
            return "( "
                + this.x
                + ","
                + this.y
                +","
                + this.z
                + ") ";


        }
    }

}
