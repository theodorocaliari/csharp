using System;
using System.Globalization;

namespace problema1002Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Área do Círculo");

            double area, pi, raio;

            pi = 3.14159;

            Console.WriteLine("Entre com o valor do raio:");

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
