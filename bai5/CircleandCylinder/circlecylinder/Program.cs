using System;

namespace circlecylinder
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle circle1 = new Circle(2, " green");
			Console.WriteLine(circle1.ToString());
			Cylinder cylinder1 = new Cylinder(3, "red", 4);
			Console.WriteLine(cylinder1.ToString());
		}

		public class Circle
		{
			protected string color { get; set; }
			protected double radius { get; set; }
			public Circle() { }
			public Circle(double radius, string color)
			{
				this.radius = radius;
				this.color = color;
			}
			public double GetArea()
			{
				return radius * radius * Math.PI;
			}
			public override string ToString()
			{
				return "A circle with color "
					+ color
					+ " radius "
					+ radius
					+ " area "
					+ GetArea();

			}
		}
		public class Cylinder : Circle
		{
			protected double height;
			public Cylinder()
			{

			}
			public Cylinder(double radius)
			{

			}
			public Cylinder(double radius, string color, double height) : base(radius, color)
			{
				this.height = height;

			}
			public double GetVolume()
			{
				return height * GetArea();
			}
			public override string ToString()
			{
				return "A cylinder with height "
					+ height
					+ " volume "
					+ GetVolume()
					+ ", which is a subclass of "
					+ base.ToString();



			}
		
		}
	}
}

