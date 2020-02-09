namespace GradingStudents
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var result = gradingStudents(new List<int> { 73, 67, 38, 33 });
            result.ForEach(r => Console.WriteLine(r));
            Console.ReadLine();
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();

            foreach (int grade in grades)
            {
                int nextMultipleFive = getNextMultipleFive(grade);
                result.Add(grade >= 38 && nextMultipleFive - grade < 3 ? nextMultipleFive : grade);
            }

            return result;
        }

        private static int getNextMultipleFive(int number)
        {
            return number += (5 - number % 5);
        }
    }
}
