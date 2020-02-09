namespace MiniMaxSum
{
    using System;

    class Program
    {
        static void Main()
        {
            miniMaxSum(new int[] { 1, 2, 3, 4, 5 });
            Console.ReadLine();
        }

        static void miniMaxSum(int[] arr)
        {
            long minSum = 0;
            long maxSum = 0;
            int len = arr.Length;

            Array.Sort(arr);

            for (int i = 0; i < len - 1; i++)
            {
                minSum += arr[i];
            }

            for (int i = 1; i < len; i++)
            {
                maxSum += arr[i];
            }

            Console.Write(minSum);
            Console.Write(" ");
            Console.Write(maxSum);
        }
    }
}
