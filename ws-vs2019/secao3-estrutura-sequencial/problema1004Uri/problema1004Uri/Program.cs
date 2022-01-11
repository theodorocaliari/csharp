using System;

namespace problema1004Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Produto Simples");
            int A, B, produto;

            Console.WriteLine("Escreva um número A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva um número B: ");
            B = int.Parse(Console.ReadLine());

            produto = A * B;

            Console.WriteLine("PROD = " + produto);
        }
    }
}
