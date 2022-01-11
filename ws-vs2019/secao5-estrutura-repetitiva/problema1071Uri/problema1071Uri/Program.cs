using System;

namespace problema1071Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, maior, menor, soma;
            soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            for (i = menor+1; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);

        }
    }
}
