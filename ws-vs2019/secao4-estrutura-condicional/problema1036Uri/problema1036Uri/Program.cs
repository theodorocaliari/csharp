using System;
using System.Globalization;

namespace problemaUri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formula de Bhaskara");
            double x1, x2, a, b, c, raizQuadrada, delta;

            Console.Write("Digite o valor de a, b e c separados com espaço:");
            string[] valor = Console.ReadLine().Split(" ");

            a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            c = double.Parse(valor[2], CultureInfo.InvariantCulture);

            //Console.Write("Digite o valor de a:");
            //a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Digite o valor de b:");
            //b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Digite o valor de c:");
            //c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (delta < 0.0 || a == 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                raizQuadrada = Math.Sqrt(delta);
                x1 = (-b + raizQuadrada) / (2.0 * a);
                x2 = (-b - raizQuadrada) / (2.0 * a);

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }
    }
}
