using System;

namespace funcoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, A, B, C;

            x = 3.0;
            y = 4.0;
            z = -5.0;

            Console.WriteLine("Usando a função de raiz quadrada Math.Sqrt()");
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine("A raiz quadrada de " + x + " é " + A.ToString("F2"));
            Console.WriteLine("A raiz quadrada de " + y + " é " + B);
            Console.WriteLine("A raiz quadrada de 25 é " + C);

            Console.WriteLine("Usando a função de potenciação Math.Pow()");
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine("O número " + x + " elevado a " + y + " é " + A + " | Math.Pow(" + x + ", " + y + ") = " + A);
            Console.WriteLine("O número " + x + " elevado a 2 é " + B);
            Console.WriteLine("O número 5 elevado a 2 é " + C);

            Console.WriteLine("Usando a função de valor absoluto Math.Abs()");
            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine("O valor absoluto de " + y + " é " + A);
            Console.WriteLine("O valor absoluto de " + z + " é " + B);
        }
    }
}
