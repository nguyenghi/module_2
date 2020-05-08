using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
     public class Product
    {
        public string name { get; set; }
        public string description { get; set;}
        public double price { get; set; }
        public int[] rate { get; set; }
        public Product()
        {

        }
        public string ViewInfo()
        {
            return $"Name:{this.name}\n Description:{ this.description}\n Price:{this.price}"; 
        }

        public int AverageRate()
        {
            var sum = 0;
            for (int i = 0; i < rate.Length; i++)
            {
                sum += rate[i];
            }

            if(rate.Length > 0)
            {
                return (int)(sum / rate.Length);
            }
            return 0;
        }
    }
}
