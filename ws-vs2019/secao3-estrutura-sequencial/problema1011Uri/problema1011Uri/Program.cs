using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Volume da Esfera");
        double raio, volume, pi;

        pi = 3.14159;
        Console.WriteLine("Entre com o valor do raio: ");
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        volume = (4 / 3.0) * pi * raio * raio * raio;

        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));


    }

}