
namespace PlusMinus
{
    using System;

    class Program
    {
        static void Main()
        {
            plusMinus(new int[] { -4, 3, -9, 0, 4, 1 });
            Console.ReadLine();
        }

        static void plusMinus(int[] arr)
        {

            int len = arr.Length;
            double p = 0;
            double n = 0;
            double z = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                {
                    p++;
                }
                else if (arr[i] < 0)
                {
                    n++;
                }
                else
                {
                    z++;
                }
            }

            p = p / len;
            n = n / len;
            z = z / len;

            Console.WriteLine(p);
            Console.WriteLine(n);
            Console.WriteLine(z);
        }
    }
}
