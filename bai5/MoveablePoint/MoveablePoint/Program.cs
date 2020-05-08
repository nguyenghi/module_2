using System;

namespace MoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(2, 3);
            Console.WriteLine(a.ToString());
            MoveablePoint b = new MoveablePoint(1, 2);
            b.Move(2, 2);
        }
    }

    class Point
    {
      protected float x { get; set; }
       protected float y { get; set; }
       public Point()
        {

        }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return this.x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return this.y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;

        }
        public void GetXY()
        {
            float[] getxy = { this.x, this.y };
            for (int i = 0; i < getxy.Length; i++)
            {
                Console.WriteLine(getxy[i]);
            }


        }
        public string ToString()
        {
            return "(" + this.x + "," + this.y + ")";
        }
    }
    class MoveablePoint : Point
    {
        protected float xSpeed;
        protected float ySpeed;
        public MoveablePoint()
        {

        }
        public MoveablePoint( float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;


        }
        public float GetxSpeed()
        {
            return this.xSpeed;
        }
        public void SetxSpeed(float xSpeed)
        {
            this.xSpeed = xSpeed;
        }
        public float GetySpeed()
        {
            return this.ySpeed;
        }
        public void SetySpeed(float ySpeed)
        {
            this.ySpeed = ySpeed;
        }
        public void SetxySpeed(float xSpeed, float ySpeed)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;

        }
        public void GetxySpeed()
        {
            float[] getxySpeed = { this.x, this.y };
            for (int i = 0; i < getxySpeed.Length; i++)
            {
                Console.WriteLine(getxySpeed[i]);
            }


        }
        public string ToString()
        {
            return "(" + this.xSpeed + "," + this.ySpeed + ")";
        }
        public void Move(float x, float y)
        {
           float x1= x + xSpeed;
           float y1 = y + ySpeed;
            Console.WriteLine("(" + x1 + "," + y1 + ")");

        }
    }
}
