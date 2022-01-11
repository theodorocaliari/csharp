using System;
using System.Globalization;

namespace problema1118Uri_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            int novoCalculo, contador;

            novoCalculo = 1;

            while (novoCalculo == 1)
            {
                nota2 = 0;
                contador = 0;

                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (contador < 2)
                {
                    if (nota1 >= 0 && nota1 <= 10)
                    {
                        nota2 += nota1;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                    if (contador < 2)
                    {
                        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }
                media = nota2 / 2.0;

                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
