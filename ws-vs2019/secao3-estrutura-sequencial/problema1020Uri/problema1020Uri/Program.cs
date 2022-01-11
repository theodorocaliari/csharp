using System;

namespace problema1020Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada, ano, mes, dias;

            entrada = int.Parse(Console.ReadLine());

            ano = entrada / 365;
            mes = (entrada % 365) / 30; //o resto da divisão 365 divide por 30 e encontra a quantia em mes
            dias = (entrada % 365) % 30; //o resto da divisão 365 calcula com o resto da divisao por 30 para encontrar o dia

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
