namespace BirthdayCakeCandles
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int r = birthdayCakeCandles(new[] { 3, 2, 1, 3 });
            Console.WriteLine(r);
            Console.ReadLine();
        }

        static int birthdayCakeCandles(int[] ar)
        {
            int max = ar.Max();
            return ar.Where(x => x == max).Count();
        }
    }
}