using System;

namespace tienlai
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double interset_rate = 1.0;

            Console.WriteLine("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate in percentage: ");
            interset_rate = Double.Parse(Console.ReadLine());

            double total_interset = 0;
            for (int i = 0; i < month; i++)
            {
                total_interset = money * (interset_rate / 100) / 12 * i;
            }

            Console.WriteLine("Total of interset: " + total_interset);
        }
    }
}
