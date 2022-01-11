using System;

namespace problema1066Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int contadorPares, contadorImpares, contadorPositivos, contadorNegativos, i;

            contadorPares = 0;
            contadorImpares = 0;
            contadorPositivos = 0;
            contadorNegativos = 0;

            for (i = 0; i < 5; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    contadorPares += 1;
                }
                else
                {
                    contadorImpares += 1;
                }

                if (numeros[i] != 0)
                {
                    if (numeros[i] > 0)
                    {
                        contadorPositivos += 1;
                    }
                    else
                    {
                        contadorNegativos += 1;
                    }
                }


            }

            Console.WriteLine(contadorPares + " valor(es) par(es)");
            Console.WriteLine(contadorImpares + " valor(es) impar(es)");
            Console.WriteLine(contadorPositivos + " valor(es) positivo(s)");
            Console.WriteLine(contadorNegativos + " valor(es) negativo(s)");

        }
    }
}
