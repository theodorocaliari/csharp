using System;

namespace problema1046Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, calculo;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if(horaInicial < 24)
            {
                horaInicial = 24 - horaInicial;
            }

            calculo = horaInicial + horaFinal;

            if(calculo > 24)
            {
                calculo = calculo - 24;
            }

            Console.WriteLine("O JOGO DUROU " + calculo + " HORA(S)");

        }
    }
}
