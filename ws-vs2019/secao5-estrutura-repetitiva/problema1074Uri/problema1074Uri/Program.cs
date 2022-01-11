using System;

namespace problema1074Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, i;


            n = int.Parse(Console.ReadLine());

            i = 0;
            do
            {
                n2 = int.Parse(Console.ReadLine());

                if (n2 == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (n2 % 2 == 0)
                {
                    if (n2 < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                }
                else
                {
                    if (n2 < 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }

                i++;
            } while (i != n);
        }
    }
}
