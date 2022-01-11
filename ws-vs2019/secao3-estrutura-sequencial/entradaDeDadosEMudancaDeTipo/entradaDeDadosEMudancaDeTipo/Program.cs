using System;
using System.Globalization;

namespace entradaDeDadosEMudancaDeTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma letra qualquer:");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número com ponto flutuante:");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite tudo em uma linha o nome, sexo, idade e altura separados com espaço:");
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
