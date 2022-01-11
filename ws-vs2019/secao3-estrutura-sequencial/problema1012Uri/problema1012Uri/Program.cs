using System;
using System.Globalization;

namespace problema1012Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Área");

            double A, B, C, pi, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

            pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);


            //base vezes altura dividido por 2 = area do triangulo
            areaTriangulo = (C * A) / 2;
            //pi vezes raio ao quadrado = area circulo
            areaCirculo = pi * C * C;
            //base maior mais base menor vezes altura dividido por 2 = area trapezio
            areaTrapezio = ((A + B) * C) / 2;
            //lado ao quadrado = area quadrado
            areaQuadrado = B * B;
            //base vezes altura = area do retangulo
            areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: "+ areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: "+ areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: "+ areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: "+ areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: "+ areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
