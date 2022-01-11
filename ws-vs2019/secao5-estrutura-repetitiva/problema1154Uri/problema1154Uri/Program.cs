using System;
using System.Globalization;

namespace problema1154Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma;
            double media, contador;

            soma = 0;
            contador = 0.0;

            n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                soma += n;
                contador = contador + 1;

                n = int.Parse(Console.ReadLine());
            }

            media = soma / contador;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
