using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
        Cat cat = new Cat("20kg", "1.5", "kitty");
        cat.PrintInfo();
        }
    }
    public abstract class Animal
    {
        protected string weight {get; set;}
        protected string height{ get; set;}
        public Animal(string weight, string height)
        {
            this.weight = weight;
            this.height = height;
        }
        public Animal()
        {

        }
        public abstract void PrintInfo();
    }
    class Cat : Animal
 {
     private string Name { get; set; }
     public Cat(string weight, string height, string name)
     : base(weight, height)
     {
           this.Name = name;
     }

     public override void PrintInfo()
     {
          Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.weight, this.height, this.Name);
     }
 }
    
}
