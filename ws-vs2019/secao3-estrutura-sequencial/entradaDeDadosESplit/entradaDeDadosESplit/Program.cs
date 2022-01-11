using System;

namespace entradaDeDadosESplit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string x, y, z, a, b, c, s, frase;

            Console.Write("Escreva uma frase:");
            frase = Console.ReadLine();

            Console.WriteLine("Digite 3 cores, 1 de cada vez, separadas por enter.");
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            Console.WriteLine("Agora digite mais 3 cores na mesma linha separadas com espaço.");

            s = Console.ReadLine();

            string[] vet = s.Split(' '); //split identifica o caracter informado e "corta" no caractere informado
            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine("Você digitou:");
            Console.WriteLine("-> " + frase);
            Console.WriteLine("-> " + x);
            Console.WriteLine("-> " + y);
            Console.WriteLine("-> " + z);
            Console.WriteLine("-> " + a);
            Console.WriteLine("-> " + b);
            Console.WriteLine("-> " + c);

        }
    }
}
