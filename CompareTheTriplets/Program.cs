namespace CompareTheTriplets
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var a = new List<int>() { 5, 6, 7 };
            var b = new List<int>() { 3, 6, 10 };

            var result = compareTriplets(a, b);
            foreach (var r in result)
            {
                Console.Write($"{r} ");
            }

            Console.ReadLine();
        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0, bob = 0;
            var result = new List<int>();

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                if (a[i] < b[i])
                {
                    bob++;
                }
            }

            result.Add(alice);
            result.Add(bob);

            return result;
        }
    }
}