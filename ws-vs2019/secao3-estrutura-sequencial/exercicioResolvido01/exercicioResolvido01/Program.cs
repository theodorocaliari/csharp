using System;
using System.Globalization;

namespace exercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, valorMetro, areaTerreno, precoTerreno;

            Console.WriteLine("Digite o valor do comprimento e largura em números decimais com 1 casa após a virgula:");
            Console.Write("Largura:");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Comprimento:");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Escreva o valor do metro quadrado, com 2 casas decimais: ");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //calculando a area
            areaTerreno = n1 * n2;

            //calculando o preco do terreno
            precoTerreno = areaTerreno * valorMetro;

            Console.WriteLine("O terreno tem área de " + areaTerreno.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do terreno é de R$" + precoTerreno.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
