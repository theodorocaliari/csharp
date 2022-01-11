using System;

namespace problema1132Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, soma, maior;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            i = 0;
            soma = 0;

            if(x > y)
            {
                maior = x;
                x = y;
                y = maior;
            }

            i = x;
            do
            {

                if (i % 13 != 0)
                {
                    soma += i;
                }
                i++;
            } while (i <= y);

            Console.WriteLine(soma);

        }
    }
}
