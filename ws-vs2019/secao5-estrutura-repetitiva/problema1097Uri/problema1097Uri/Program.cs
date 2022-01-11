using System;

namespace programa1097Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, loop;

            loop = 0;
            i = 0;
            do
            {
                if (i % 2 != 0)
                {
                    for (j = 7; j >= 5; j--)
                    {
                        Console.WriteLine($"I={i} J={j+loop}");
                    }
                    loop += 2;
                }
                i++;
                
            } while (i != 10);
        }
    }
}
