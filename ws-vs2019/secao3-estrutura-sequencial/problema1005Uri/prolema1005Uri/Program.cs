using System;
using System.Globalization;

namespace prolema1005Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média 1");

            double A, pesoA, B, pesoB, mediaPonderada;
            pesoA = 3.5;
            pesoB = 7.5;

            Console.WriteLine("Digite o valor da nota A: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor da nota B: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaPonderada = ((A * pesoA) + (B * pesoB)) / (pesoA + pesoB);

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
