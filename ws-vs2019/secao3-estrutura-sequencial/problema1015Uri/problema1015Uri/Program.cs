using System;
using System.Globalization;

namespace problema1015Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            Console.WriteLine("Digite o valor de X1 e Y1 na mesma linha:");
            string[] ponto1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Digite o valor de X2 e Y2 na mesma linha:");
            string[] ponto2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(ponto1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(ponto1[1], CultureInfo.InvariantCulture);

            x2 = double.Parse(ponto2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(ponto2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) );

            Console.WriteLine("A distância entre o ponto1 e ponto2 é: " + distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
