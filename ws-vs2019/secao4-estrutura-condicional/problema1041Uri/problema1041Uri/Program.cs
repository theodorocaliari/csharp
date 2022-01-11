using System;
using System.Globalization;

namespace problema1041Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            //quadrante 1 - x e y positivos
            //quadrante 2 - x negativo e y positivo
            //quadrante 3 - x e y negativo
            //quadrante 4 - x positivo e y negativo

            string[] vet = Console.ReadLine().Split(' ');

            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

        }
    }
}
