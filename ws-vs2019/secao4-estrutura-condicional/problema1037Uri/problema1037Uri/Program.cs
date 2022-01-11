using System;
using System.Globalization;

namespace problema1037Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            string resultado;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0)
            {
                resultado = "Fora de intervalo";
            }
            else if (valor == 0.00000 || valor <= 25.00000)
            {
                resultado = "Intervalo [0,25]";
            }
            else if (valor <= 50.00000)
            {
                resultado = "Intervalo (25,50]";
            }
            else if (valor <= 75.00000)
            {
                resultado = "Intervalo (50,75]";
            }
            else if (valor <= 100.00000)
            {
                resultado = "Intervalo (75,100]";
            }
            else
            {
                resultado = "Fora de intervalo";
            }

            Console.WriteLine(resultado);

        }
    }
}
