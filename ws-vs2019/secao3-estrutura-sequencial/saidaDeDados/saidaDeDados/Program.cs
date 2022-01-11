using System;
using System.Globalization; 

namespace saidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saida de dados com o método Console.Write");
            Console.Write("Saida 1");
            Console.Write("Saida 2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Saida de dados com o método Console.WriteLine");
            Console.WriteLine("Saida 1");
            Console.WriteLine("Saida 2");

            double x = 10.35784;
            char y = 'M';
            int w = 32;
            string z = "Lucas";
            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F7"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine();

            Console.WriteLine(z + " tem " + w + " anos e seu sexo é " + y);


            Console.ReadLine();
        }
    }
}
