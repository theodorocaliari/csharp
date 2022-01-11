using System;
using System.Globalization;

namespace estruturaCondicionalExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, corte, soma;

            corte = 60.0;

            Console.Write("Digite o valor da nota 1:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor da nota 2:");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = (nota1 + nota2);

            if(soma < corte)
            {
                Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture) + "\nREPROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
