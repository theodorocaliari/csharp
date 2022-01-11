using System;

namespace problema1019Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um valor em segundos: ");
            int N, resto, hora, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            hora = N / 3600; //1h = 60min = 3600s
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.Write(hora + ":" + minutos + ":" + segundos);

        }
    }
}
