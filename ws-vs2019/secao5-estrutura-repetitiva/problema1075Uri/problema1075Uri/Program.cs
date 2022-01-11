using System;

namespace problema1075Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            i = 0;
            n = int.Parse(Console.ReadLine());

            do
            {
                if (i % n == 2)
                {
                    Console.WriteLine(i);
                }

                i++;
            } while (i < 100);
        }
    }
}
