namespace DrawingBook
{
    using System;

    class Program
    {
        static void Main()
        {
            int r = pageCount(6, 2);
            Console.WriteLine(r);
            Console.ReadLine();
        }

        static int pageCount(int n, int p)
        {
            int step = 0;

            if (p == 1 || p == n)
            {
                step = 0;
            }
            else if (p % 2 != 0 && p == n - 1)
            {
                step = 1;
            }
            else if (p <= n / 2)
            {
                for (int i = 1; i <= p / 2; i++)
                {
                    step++;
                }
            }
            else
            {
                step = (n - p) / 2;
            }

            return step;
        }
    }
}
