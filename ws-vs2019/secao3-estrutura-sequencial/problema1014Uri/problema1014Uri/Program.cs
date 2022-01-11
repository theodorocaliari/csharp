using System;
using System.Globalization;

namespace problema1014Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, consumo;

            Console.WriteLine("Digite o total da distância percorrida em KM:");
            X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o total de combustível gasto em litros:");
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
