using System;
using System.Linq.Expressions;

namespace ChuyenHCS
{
    class Program
    {
        static void Main(string[] args)
        {
            So a = new So();
            Console.WriteLine("nhap so");
            a.giatri = Console.ReadLine();
            Console.WriteLine("nhap hcs");
            a.hcs = Console.ReadLine();
            if (Check(a.giatri, a.hcs))
            {
                Console.WriteLine(a.ChuyenHCS(a.giatri, a.hcs));
            }

            else
            {
                Console.WriteLine("nhap lai: ");
            }
            
            
        }
        public  static bool Check(string giatri, string hcs)

        { 
            bool check = true;
            switch (hcs)
            {
                case "2":
                    
                    for (int i = 0; i < giatri.Length; i++)
                    {
                        string value = giatri[i].ToString().ToLower();

                        if (value !="0" && value  != "1")
                        {
                             check = false;
                        }

                    }
                    return check;
                    

                case "8":
                    for (int i = 0; i < giatri.Length; i++)
                    {
                        string value = giatri[i].ToString().ToLower();

                        if (value != "0" && value != "1"&&
                            value != "2" && value != "3"&&
                            value != "4" && value != "5"&&
                            value != "6" && value != "7" )
                        {
                            check = false;
                        }

                    }
                    return check;

                    
                case "16":
                    for (int i = 0; i < giatri.Length; i++)
                    {
                        string value = giatri[i].ToString().ToLower();

                        if (value != "0" && value != "1" &&
                            value != "2" && value != "3" &&
                            value != "4" && value != "5" &&
                            value != "6" && value != "7" &&
                            value != "8" && value != "9" &&
                            value != "a" && value != "b" &&
                            value != "c" && value != "d" &&
                             value != "e" && value != "f" 
                            )
                        {
                            check = false;
                        }
                    }
                    return check;

                    

            }
            return check;


        }
    }
}
