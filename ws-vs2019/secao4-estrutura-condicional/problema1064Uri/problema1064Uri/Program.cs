using System;
using System.Globalization;

namespace problema1064Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = new double[6];
            int i, contador;
            double somapositivos, media;

            contador = 0;
            somapositivos = 0;

            for (i = 0; i < 6; i++)
            {
                //Console.Write("{0}", i + 1);
                n[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            foreach (double num in n)
            {
                if (num > 0)
                {
                    contador += 1;
                    somapositivos += num;
                }

            }

            media = somapositivos / contador;


            Console.WriteLine(contador + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
