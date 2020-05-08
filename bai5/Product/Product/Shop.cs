using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Products
{
    public class Shop: Product
    {
        public Product [] ProductList = new Product[0];
       
        public void AddProduct( Product [] ProductList, Product product)
        {
            Array.Resize(ref ProductList, ProductList.Length + 1);
            ProductList[ProductList.Length - 1] = product;
        
        }
        public void CheckName(string name)
        {

        }
        public void RemoveProduct(string name)
        {
            for(int i= 0; i< ProductList.Length; i++)
            {
                if (name.ToLower() == ProductList[i].name.ToLower())
                {
                    ProductList[i] = ProductList[i + 1];
                    Array.Resize(ref ProductList, ProductList.Length - 1);

                }
            }
        }
        public void IterrateProductList(string name)
        {
            for (int i = 0; i < ProductList.Length; i++)
            {
                if (name.ToLower() == ProductList[i].name.ToLower())
                {
                    ProductList[i].ViewInfo();
                    //for( int j =0; j < ProductList[i].rate.Length; j++)
                    // {
                    //     double rate, sumrate = 0;
                    //     sumrate += ProductList[i].rate[j];
                    //     rate = sumrate / ProductList[i].rate.Length;
                    // }
                    var aveRate = ProductList[i].AverageRate();

                }
            }
          
        }
        public void SearchProduct(int n1, int n2)
        {
          
            for( int i = 0; i < ProductList.Length; i++)
            {
                if( i == n1 || i== n2)
                {
                    ProductList[i].ViewInfo();
                   
                }
              if ( ProductList[n1].price > ProductList[n2].price)
                {
                    Console.WriteLine("Product1 price is more expensive than Product2 price");
                }
              else if (ProductList[n1].price == ProductList[n2].price)
                {
                    Console.WriteLine("Product1 price is the same as Product2 price");
                }
                else
                {
                    Console.WriteLine("Product1 price is chaeper Product2 price");
                }

            }
            
            
        }

    }
}
