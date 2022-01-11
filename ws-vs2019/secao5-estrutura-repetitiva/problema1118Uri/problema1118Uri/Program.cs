using System;
using System.Globalization;

namespace problema1118Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            int novoCalculo;

            novoCalculo = 1;
            while (novoCalculo == 1)
            {
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n1 < 0 || n1 > 10)
                {
                    Console.WriteLine("nova invalida");
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (n2 < 0 || n2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (n1 + n2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while(novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }

            }

        }
    }
}
