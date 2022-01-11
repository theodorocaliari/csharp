using System;
using System.Globalization;

namespace problema1021Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, resto, notas, moedas;

            Console.WriteLine("Insira um valor monetário: ");

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notas = (valor * 100) / 10000.00;
            resto = (valor * 100) % 10000.00;

            Console.WriteLine("NOTAS:");
            Console.WriteLine((int)notas + " nota(s) de R$ 100.00", CultureInfo.InvariantCulture); //casting
            notas = resto / 5000.00;
            resto = resto % 5000.00;

            Console.WriteLine((int)notas + " nota(s) de R$ 50.00", CultureInfo.InvariantCulture);
            notas = resto / 2000.00;
            resto = resto % 2000.00;

            Console.WriteLine((int)notas + " nota(s) de R$ 20.00", CultureInfo.InvariantCulture);
            notas = resto / 1000.00;
            resto = resto % 1000.00;

            Console.WriteLine((int)notas + " nota(s) de R$ 10.00", CultureInfo.InvariantCulture);
            notas = resto / 500.00;
            resto = resto % 500.00;

            Console.WriteLine((int)notas + " nota(s) de R$ 5.00", CultureInfo.InvariantCulture);
            notas = resto / 200.00;
            resto = resto % 200.00;

            Console.WriteLine((int)notas + " nota(s) de R$ 2.00", CultureInfo.InvariantCulture);
            moedas = resto / 100.00;
            resto = resto % 100.00;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)moedas + " moeda(s) de R$ 1.00", CultureInfo.InvariantCulture);
            moedas = resto / 50.00;
            resto = resto % 50.00;
            Console.WriteLine((int)moedas + " moeda(s) de R$ 0.50", CultureInfo.InvariantCulture);
            moedas = resto / 25.00;
            resto = resto % 25.00;
            Console.WriteLine((int)moedas + " moeda(s) de R$ 0.25", CultureInfo.InvariantCulture);
            moedas = resto / 10.00;
            resto = resto % 10.00;
            Console.WriteLine((int)moedas + " moeda(s) de R$ 0.10", CultureInfo.InvariantCulture);
            moedas = resto / 5.00;
            resto = resto % 5.00;
            Console.WriteLine((int)moedas + " moeda(s) de R$ 0.05", CultureInfo.InvariantCulture);
            moedas = resto / 1.00;
            resto = resto % 1.00;
            Console.WriteLine((int)moedas + " moeda(s) de R$ 0.01", CultureInfo.InvariantCulture);

        }
    }
}
