using System;

namespace estruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, soma;

            valor = int.Parse(Console.ReadLine());
            soma = 0;

            while(valor != 0)
            {
                soma += valor;
                valor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(soma);
        }
    }
}
