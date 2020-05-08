using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAnimal
{
     public class Tiger: Animal, IEdible
    {
        public string HowtoEat()
        {
          return "could be fried"  ;
        }

        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }
}
