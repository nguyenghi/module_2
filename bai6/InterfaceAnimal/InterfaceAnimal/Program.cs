using System;

namespace InterfaceAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
            Chicken chic = new Chicken();
            Console.WriteLine(chic.HowtoEat());
            Fruit[] fruits = new Fruit[1];
            fruits[0] = new Apple();
            foreach( Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowtoEat());
            }


        }

    }
}
