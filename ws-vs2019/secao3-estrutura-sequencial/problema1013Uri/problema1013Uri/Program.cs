using System;

namespace problema1013Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB, maiorABC;

            Console.WriteLine("Digite 3 valores na mesma linha:");
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2; //formula que retorna o número maior
            maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");


        }
    }
}
