using System;
using System.Globalization;

namespace problema1051aUri
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario > 4500.00)
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }



        }
    }
}
