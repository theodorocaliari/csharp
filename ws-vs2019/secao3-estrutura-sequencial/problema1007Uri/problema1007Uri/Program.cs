using System;

namespace problema1007Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diferença");

            int A, B, C, D, dif;

            Console.WriteLine("Digite um valor para A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            B = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite um valor para C: ");
            C = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite um valor para D: ");
            D = int.Parse(Console.ReadLine());

            dif = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + dif);



        }
    }
}
