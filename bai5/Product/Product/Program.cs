using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop [] ProductList = new Shop[0];
            Shop product = new Shop();

            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add new Product");
                Console.WriteLine("2. Remove a product ");
                Console.WriteLine("3. Iterate product list ");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Nhap su lua chon ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        Add(ProductList, product);
                        option = -1;
                        break;
                    case 2:
                        Remove(product);
                        option = -1;
                        break;
                    case 3:
                        Iterate(product);
                        option = -1;
                        break;

                    case 4:
                        Search(ProductList, product);
                        break;
                    case 5:
                        Environment.Exit(Environment.ExitCode);
                        break;


                }
            }
        }
        static void Add( Shop[] ProductList, Shop product)
        {
            Product product1 = new Product();
            Console.WriteLine("Input name");
            product1.name = Console.ReadLine();
            Console.WriteLine("Input price");
            product1.price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input depcription");
            product1.description = Console.ReadLine();
            Console.WriteLine("input rate");
             
            for(int i = 0; i < product1.rate.Length; i++)
            {
                Console.WriteLine("input rate");
                int n = int.Parse(Console.ReadLine());
                if(n > 0 && n < 5)
                {
                    //Array.Resize(ref product1.rate ,product1.rate.Length+1) ;
                    //product1.rate[i] = n;
                }

            }
            


            product.AddProduct( ProductList, product1);

        }
        static void Remove(Shop product)
        {
            Console.WriteLine("Input name");
            string name = Console.ReadLine();
            product.RemoveProduct(name);


        }
        static void Iterate(Shop product)
        {
            Console.WriteLine("Input name");
            string name = Console.ReadLine();
            product.IterrateProductList(name);

        }
        static void Search(Shop[] ProductsList, Shop product)
        {
            int n1, n2;
            Console.WriteLine("input number 1:" );
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("input number 2:");
            n2 = int.Parse(Console.ReadLine());
            if (n1 < ProductsList.Length && n2 < ProductsList.Length)
            {
                product.SearchProduct(n1, n2);
            }
        }
    }
}

