namespace Staircase
{
    using System;

    class Program
    {
        static void Main()
        {
            staircase(6);
            Console.ReadLine();
        }

        static void staircase(int n)
        {
            int s = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - s; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < s; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
                s++;
            }
        }
    }
}
