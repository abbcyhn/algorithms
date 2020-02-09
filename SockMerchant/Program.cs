namespace SockMerchant
{
    using System;

    class Program
    {
        static void Main()
        {
            int r = sockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            Console.WriteLine(r);
            Console.ReadLine();
        }

        static int sockMerchant(int n, int[] ar)
        {
            int[] pairsToSell = new int[n];
            int countToSell = 0;
            foreach (int sock in ar)
            {
                var ind = sock % n;
                pairsToSell[ind] += 1;
                if (pairsToSell[ind] == 2)
                {
                    countToSell++;
                    pairsToSell[ind] = 0;
                }
            }
            return countToSell;
        }
    }
}
