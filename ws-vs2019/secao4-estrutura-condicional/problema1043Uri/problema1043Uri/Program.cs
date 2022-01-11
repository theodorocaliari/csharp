using System;
using System.Globalization;

namespace problema1043Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, area, perimetro;
            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //determinar se é triangulo
            if ((Math.Abs(b - c)) < a && a < (b + c) && (Math.Abs(a - c)) < b && b < (a + c) && (Math.Abs(a - b)) < c && c < (b + a))
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }

}
