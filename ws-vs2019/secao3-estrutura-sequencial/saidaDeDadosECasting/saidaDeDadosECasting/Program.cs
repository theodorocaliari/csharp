using System;

namespace saidaDeDadosECasting
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exemplo 1:");
            int x, y;

            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();

            Console.WriteLine("Exemplo 2:");

            int j;
            double k;

            j = 5;
            k = 2 * j;

            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine();

            Console.WriteLine("Exemplo 3:");

            Console.WriteLine("Calculo da area do trapézio:");

            double h, B, b, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (B + b) / 2.0 * h;

            Console.WriteLine(area);


            Console.WriteLine("Exemplo 4:");
            Console.WriteLine("Aplicando o Casting");

            int m, n;
            double resultado;

            m = 2;
            n = 5;

            resultado = (double) n/m; //casting define o tipo do retorno esperado

            Console.WriteLine(resultado);

            Console.WriteLine("Exempli 5: ");

            double c;
            int d;

            c = 5.0;
            d = (int) c;
            









        }
    }
}
