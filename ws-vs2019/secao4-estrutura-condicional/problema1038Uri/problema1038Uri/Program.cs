using System;
using System.Globalization;

namespace problema1038Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, total;

            total = 0.0;

            Console.Write("Digite o código: ");
            codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    Console.WriteLine("Cod 1: Cachorro quente - preço: 4.00");
                    Console.Write("Digite a quantidade: ");
                    quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = quantidade * preco;
                    break;
                case 2:
                    preco = 4.50;
                    Console.WriteLine("Cod 2: X-Salada - preço: 4.50");
                    Console.Write("Digite a quantidade: ");
                    quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = quantidade * preco;
                    break;
                case 3:
                    preco = 5.00;
                    Console.WriteLine("Cod 3: X-Bacon - preço: 5.0");
                    Console.Write("Digite a quantidade: ");
                    quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = quantidade * preco;
                    break;
                case 4:
                    preco = 2.00;
                    Console.WriteLine("Cod 4: Torrada - preço: 2.0");
                    Console.Write("Digite a quantidade: ");
                    quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = quantidade * preco;
                    break; 
                case 5:
                    preco = 1.50;
                    Console.WriteLine("Cod 5: Refrigerante - preço: 1.50");
                    Console.Write("Digite a quantidade: ");
                    quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    total = quantidade * preco;
                    break;
                default:
                    Console.WriteLine("Código não encontrado");
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
