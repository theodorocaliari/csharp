using System;

namespace problema1078Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, resultado;

            n = int.Parse(Console.ReadLine());

            if(n > 2 && n < 1000)
            {
                for(i = 1; i <= 10; i++)
                {
                    resultado = i * n;
                    Console.WriteLine($"{i} x {n} = {resultado}");
                    Console.WriteLine("{0} x {1} = {2}", i, n, resultado);
                }

            }
        }
    }
}
