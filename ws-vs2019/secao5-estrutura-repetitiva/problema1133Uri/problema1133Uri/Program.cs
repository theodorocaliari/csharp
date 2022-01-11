using System;

namespace problema1133Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, maior, menor;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }
            i = menor;

            while (i < maior)
            {
                if (i > menor && i < maior)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
                i++;
            }

        }
    }
}
