using System;
using System.Collections.Generic;
using System.Text;

namespace absolute_number_calculator
{
     public class AbsoluteNumberCalculator
    {
      public int FindAbsolute( int number)
        {
            if ( number< 0)
            {
                number = -number;
            };
            return number;
        }
    }
}
