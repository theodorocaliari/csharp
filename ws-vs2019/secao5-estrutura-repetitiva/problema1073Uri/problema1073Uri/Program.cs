using System;

namespace problema1073Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            n = int.Parse(Console.ReadLine());

            i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                }

                i++;
            } while (i != n+1);
        }
    }
}
