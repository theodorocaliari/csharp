using System;
using System.Globalization;
namespace problema1006Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media 2");

            double A, B, C, pesoA, pesoB, pesoC, media;

            pesoA = 2.0;
            pesoB = 3.0;
            pesoC = 5.0;

            Console.WriteLine("Digite a nota A (Ex.: 0.0)");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota B (Ex.: 0.0)");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a nota C (Ex.: 0.0)");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * pesoA) + (B * pesoB) + (C * pesoC)) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));


        }
    }
}
