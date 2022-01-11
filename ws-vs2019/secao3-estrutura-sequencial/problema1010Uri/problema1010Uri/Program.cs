using System;
using System.Globalization;

namespace problema1010Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo Simples");

            int codigoPeca1, quantiaPeca1, codigoPeca2, quantiaPeca2;
            double valorUnidadePeca1, valorUnidadePeca2, total;

            Console.WriteLine("Digite o codigo, quantia e preço, separados por espaço, para a peça 1");
            string[] vet = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(vet[0]);
            quantiaPeca1 = int.Parse(vet[1]);
            valorUnidadePeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo, quantia e preço, separados por espaço, para a peça 2");
            string[] vet2 = Console.ReadLine().Split(' ');

            codigoPeca2 = int.Parse(vet2[0]);
            quantiaPeca2 = int.Parse(vet2[1]);
            valorUnidadePeca2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = ((quantiaPeca1 * valorUnidadePeca1) + (quantiaPeca2 * valorUnidadePeca2));

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
