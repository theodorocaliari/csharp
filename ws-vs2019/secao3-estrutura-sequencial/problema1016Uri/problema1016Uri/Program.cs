using System;

namespace problema1016Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaFornecida, qtdminutos;
            Console.WriteLine("Entre com a distância do carro X");
            distanciaFornecida = int.Parse(Console.ReadLine());

            qtdminutos = (60*distanciaFornecida) / 30;

            Console.WriteLine("O carro Y percorre a distandia de "+ distanciaFornecida +" em " + qtdminutos + " minutos");
        }
    }
}
