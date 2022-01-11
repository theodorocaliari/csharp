using System;

namespace programa1096Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            i = 0;
            do
            {
                if (i % 2 != 0)
                {
                    for (j = 7; j >= 5; j--)
                    {
                        Console.WriteLine($"I={i} J={j}");
                    }
                }
                i++;
            } while (i != 10);
        }
    }
}
