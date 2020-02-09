namespace BonAppetit
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            bonAppetit(new List<int> { 3, 10, 2, 9 }, 1, 12);
            Console.ReadLine();
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            int sum = 0;
            for (int i = 0; i < bill.Count(); i++)
            {
                if (i != k)
                {
                    sum += bill[i];
                }
            }

            int result = b - sum / 2;
            if (result > 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}
