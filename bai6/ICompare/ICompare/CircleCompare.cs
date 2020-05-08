using System;
using System.Collections.Generic;
using System.Text;

namespace Shape

{
    class CircleCompare : Icompare
    {
       

        public int Compare( Circle c1, Circle c2)
        {
            if (c1.GetRadius() > c2.GetRadius()) return 1;
            else if (c1.GetRadius() < c2.GetRadius()) return -1;
            else return 0;
        }

        public int Compare()
        {
            throw new NotImplementedException();
        }
    }
}
