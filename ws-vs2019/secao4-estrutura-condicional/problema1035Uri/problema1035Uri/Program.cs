using System;

namespace problema1035Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, soma1, soma2;
            bool numeroPar;
            string resultado;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);

            resultado = "Valores nao aceitos";
            numeroPar = false;

            soma1 = c + d;
            soma2 = a + b;

            if (a % 2 == 0){
                numeroPar = true;            
            }

            if(b > c && d > a)
            {
                if(soma1 > soma2 && c > 0 && d > 0)
                {
                    if(numeroPar == true)
                    {
                        resultado = "Valores aceitos";
                    }
                }
            }

            Console.WriteLine(resultado);

        }
    }
}
