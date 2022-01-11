using System;

namespace problema1047Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, minutoInicial, minutoFinal, tempoInicio, tempoFim, duracao, duracaoHora, duracaoMinuto;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            tempoInicio = (horaInicial * 60) + minutoInicial;
            tempoFim = (horaFinal * 60) + minutoFinal;

            if (tempoInicio < tempoFim)
            {
                duracao = tempoFim - tempoInicio;
            }
            else
            {
                duracao = (24 * 60 - tempoInicio) + tempoFim;
            }

            duracaoHora = duracao / 60;
            duracaoMinuto = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHora + " HORA(S) E " + duracaoMinuto + " MINUTO(S)");
        }
    }
}