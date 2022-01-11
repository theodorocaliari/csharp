using System;
using System.Globalization;

namespace problemaExemploFacaEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius, fahrenheit;
            string escolha;

            do
            {
                Console.Write("Digite a temperatura em Celcius:");
                celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                fahrenheit = ((9.0 * celcius) / 5.0) + 32;

                Console.WriteLine($"Equivalente em Fahrenheit:{fahrenheit.ToString("F1", CultureInfo.InvariantCulture)}");

                Console.Write("Deseja Repetir(s/n)?");
                escolha = Console.ReadLine();
            } while (escolha == "s");
        }
    }
}
