using System;

namespace problema1080Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, contador, posicao, maior, compara;

            maior = 0;
            posicao = 0;
            contador = 1;
            compara = 0;
            v2 = 0;

            do
            {
                v1 = int.Parse(Console.ReadLine());
                v2 = v1;
                if (v2 > compara)
                {
                    compara = v2;
                    posicao = contador;
                    maior = compara;
                }

                contador++;

            } while (contador <= 100);


            Console.WriteLine(maior);
            Console.WriteLine(posicao);

        }
    }
}
