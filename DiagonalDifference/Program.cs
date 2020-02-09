
namespace DiagonalDifference
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var arr = new List<List<int>>
            {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };

            int diff = diagonalDifference(arr);

            Console.WriteLine(diff);
            Console.ReadLine();
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int d1 = 0;
            int d2 = 0;
            int n = arr.Count();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Count(); j++)
                {
                    if (i == j)
                    {
                        d1 += arr[i][j];
                    }
                    if (i == n - j - 1)
                    {
                        d2 += arr[i][j];
                    }
                }
            }

            return d2 > d1 ? d2 - d1 : d1 - d2;
        }
    }
}
