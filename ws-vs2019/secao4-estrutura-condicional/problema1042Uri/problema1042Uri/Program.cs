using System;

namespace problema1042Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x, y, z;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a > b && a > c)
            {
                x = a;

                if (b > c)
                {
                    y = b;
                    z = c;
                }
                else
                {
                    y = c;
                    z = b;
                }
            }
            else if (b > a && b > c)
            {
                x = b;
                if (a > c)
                {
                    y = a;
                    z = c;
                }
                else
                {
                    y = c;
                    z = a;
                }
            }
            else
            {
                x = c;

                if (a > b)
                {
                    y = a;
                    z = b;
                }
                else
                {
                    y = b;
                    z = a;
                }
                
            }

            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
