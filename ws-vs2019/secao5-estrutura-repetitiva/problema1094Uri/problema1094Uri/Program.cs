using System;
using System.Globalization;

namespace problema1094Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int testes, coelho, rato, sapo, total;
            double porcentagemCoelho, porcentagemRato, porcentagemSapo;
            string[] quantia = new string[2];

            testes = int.Parse(Console.ReadLine());

            coelho = 0;
            sapo = 0;
            rato = 0;
            total = 0;

            do
            {

                quantia = Console.ReadLine().Split(' ');

                if (quantia[1] == "c" || quantia[1] == "C")
                {
                    coelho += int.Parse(quantia[0]);
                }

                if (quantia[1] == "r" || quantia[1] == "R")
                {
                    rato += int.Parse(quantia[0]);
                }

                if (quantia[1] == "s" || quantia[1] == "S")
                {
                    sapo += int.Parse(quantia[0]);
                }

                total += int.Parse(quantia[0]);

                testes--;
            }
            while (testes != 0);

            porcentagemCoelho = (coelho / (double)total) * 100;
            porcentagemRato = (rato / (double)total) * 100;
            porcentagemSapo = (sapo / (double)total) * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelho}");
            Console.WriteLine($"Total de ratos: {rato}");
            Console.WriteLine($"Total de sapos: {sapo}");
            Console.WriteLine($"Percentual de coelhos: {porcentagemCoelho.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemRato.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemSapo.ToString("F2", CultureInfo.InvariantCulture)} %");

        }
    }
}
