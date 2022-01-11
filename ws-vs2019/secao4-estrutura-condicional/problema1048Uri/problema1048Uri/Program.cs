using System;
using System.Globalization;

namespace problema1048Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste, fracao, percentual;
            

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario == 0 || salario <= 400.00)
            {
                fracao = 0.15;
            }
            else if (salario == 400.01 || salario <= 800.00)
            {
                fracao = 0.12;
            }
            else if (salario == 800.01 || salario <= 1200.00)
            {
                fracao = 0.10;
            }
            else if (salario == 1200.01 || salario <= 2000.00)
            {
                fracao = 0.07;
            }
            else
            {
                fracao = 0.04;
            }

            percentual = fracao * 100;
            reajuste = salario * fracao;
            novoSalario = reajuste + salario;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + (int) percentual + " %");



        }
    }
}
