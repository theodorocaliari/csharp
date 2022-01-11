using System;

namespace problema1003Uri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Soma Simples");

            int A, B, soma;

            Console.WriteLine("Entre com um número A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um número B: ");
            B = int.Parse(Console.ReadLine());
            soma = A + B;

            Console.WriteLine("SOMA = " + soma);

        }
    }
}
