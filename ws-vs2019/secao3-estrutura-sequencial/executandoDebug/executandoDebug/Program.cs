using System;
using System.Globalization;

namespace executandoDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, valorMetro, areaTerreno, precoTerreno;

            Console.WriteLine("Digite o valor do comprimento e largura em números decimais com 1 casa após a virgula:");
            Console.Write("Largura:");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Comprimento:");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Escreva o valor do metro quadrado, com 2 casas decimais: ");
            valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //para excutar o debug, selecionamos a linha desejada para iniciar o debug e teclamos a tecla f9 para marcar a linha
            //executar o projeto com f5, e a tecla f10 para ir avançando passo a passo para as linhas seguintes

            //calculando a area
            areaTerreno = largura * comprimento;

            //calculando o preco do terreno
            precoTerreno = areaTerreno * valorMetro;

            Console.WriteLine("O terreno tem área de " + areaTerreno.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do terreno é de R$" + precoTerreno.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
