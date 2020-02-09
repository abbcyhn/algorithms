namespace TimeConversion
{
    using System;

    class Program
    {
        static void Main()
        {
            string s = timeConversion("07:05:45PM");
            Console.WriteLine(s);
            Console.ReadLine();
        }

        static string timeConversion(string s)
        {
            string[] parts = s.Split(':');

            if (parts[2].EndsWith("AM"))
            {
                int t = int.Parse(parts[0]);
                if (t == 12)
                {
                    parts[0] = "00";
                }
                else if (t < 10)
                {
                    parts[0] = "0" + t.ToString();
                }
                else
                {
                    parts[0] = t.ToString();
                }
            }
            else
            {
                int t = int.Parse(parts[0]);
                t = t == 12 ? t : t += 12;
                parts[0] = t == 24 ? "00" : t.ToString();
            }

            s = parts[2];
            s = s.Remove(s.Length - 2);

            return string.Format("{0}:{1}:{2}", parts[0], parts[1], s);
        }
    }
}