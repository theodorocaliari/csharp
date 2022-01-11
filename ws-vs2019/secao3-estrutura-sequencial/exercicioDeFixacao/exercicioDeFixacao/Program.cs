using System;

namespace exercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numeroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com ultimo nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("Você escreveu:");
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
