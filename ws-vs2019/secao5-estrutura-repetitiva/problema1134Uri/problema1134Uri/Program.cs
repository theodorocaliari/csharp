using System;

namespace problema1134Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, etanol, gasolina, diesel, invalido;

            etanol = 0;
            gasolina = 0;
            diesel = 0;
            invalido = 0;

            n = int.Parse(Console.ReadLine());

            while (n != 4)
            {
                switch (n)
                {
                    case 1:
                        etanol += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    default:
                        invalido += 1;
                        break;
                }

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + etanol);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            //Console.WriteLine("Invalido: " + invalido);

        }
    }
}
