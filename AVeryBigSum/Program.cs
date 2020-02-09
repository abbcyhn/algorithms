namespace AVeryBigSum
{
    using System;

    class Program
    {
        static void Main()
        {
            long r = aVeryBigSum(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 });
            Console.WriteLine(r);
            Console.ReadLine();
        }

        static long aVeryBigSum(long[] ar)
        {
            long r = 0;

            foreach (long a in ar)
            {
                r += a;
            }

            return r;
        }
    }
}
