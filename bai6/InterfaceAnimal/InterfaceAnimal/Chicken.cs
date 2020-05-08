using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAnimal
{
    class Chicken : Animal , IEdible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
       

        public string HowtoEat()
        {
            return "could be fried";
        }
    }
}
