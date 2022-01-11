using System;
using System.Globalization;

namespace exercicioResolvido2EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            double media, idade, soma;

            count = 0;
            soma = 0.0;
            media = 0.0;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                count += 1;
                soma += idade;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (count != 0)
            {
                media = soma / count;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossível Calcular");
            }


        }
    }
}
