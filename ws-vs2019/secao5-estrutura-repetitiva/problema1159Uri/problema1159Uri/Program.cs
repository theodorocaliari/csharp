using System;

namespace problema1159Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i, nAnterior, soma;
            i = 0;
            nAnterior = 0;
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if(x % 2 != 0)
                {
                    x = x + 1;
                }

                soma = x;
                while (i < 5)
                {
                    nAnterior = nAnterior + soma;
                    soma += 2;
                    i++;
                }

                Console.WriteLine(nAnterior);

                x = int.Parse(Console.ReadLine());
                i = 0;
                nAnterior = 0;
            }
        }
    }
}
