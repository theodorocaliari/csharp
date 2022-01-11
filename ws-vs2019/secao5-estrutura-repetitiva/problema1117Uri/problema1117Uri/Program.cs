using System;
using System.Globalization;

namespace problema1117Uri
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, media;
            bool valoresValidos = false;

            while (valoresValidos == false)
            {
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (n1 > 0 && n1 <= 10.0 && n2 > 0 && n2 <= 10.0)
                {
                    media = n1 + n2 / 2.0;
                    Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
                    valoresValidos = true;
                }
                else
                {
                    Console.WriteLine("nota inválida");
                }

            }
        }
    }
}
