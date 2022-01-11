using System;

namespace problema1067Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;

            x = int.Parse(Console.ReadLine());

            i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            } while (i <= x);
        }
    }
}
