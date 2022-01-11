using System;

namespace problema1017Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, velocidade, tempo;
            double consumo;

            Console.WriteLine("Entre com o tempo gasto na viagem: ");
            tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a velocidade: ");
            velocidade = int.Parse(Console.ReadLine());

            distancia = velocidade * tempo;

            consumo = distancia / 12.0;

            Console.WriteLine("A distância percorrida é: " + distancia + "km");

            Console.WriteLine("O consumo de combustível é de: " + consumo.ToString("F3") + "km/l");

        }
    }
}
