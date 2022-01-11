using System;
using System.Globalization;

namespace problema1051Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto, diferenca;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            imposto = 0.0;

            /**/
            if (salario > 4500)
            {
                imposto = 1000 * 0.08 + 1500 * 0.18;
                diferenca = salario - 4500;
                imposto += diferenca * 0.28;
            }
            else if (salario > 3000)
            {
                imposto = 1000 * 0.08;
                diferenca = salario - 3000;
                imposto += diferenca * 0.18;

            }
            else if (salario > 2000)
            {
                imposto = salario - 2000;
                imposto = imposto * 0.08;
            }

            if (imposto > 0)
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Isento");
            }
        }
    }
}

