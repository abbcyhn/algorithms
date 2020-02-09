namespace IceCreamParlor
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        }

        static int[] icecreamParlor(int m, int[] arr)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int value = arr[i];
                int complements = m - value;

                if (dict.ContainsKey(value))
                {
                    return new int[] { dict[value] + 1, i + 1 };
                }
                else if (!dict.ContainsKey(complements))
                {
                    dict.Add(complements, i);
                }
            }

            return null;
        }
    }
}