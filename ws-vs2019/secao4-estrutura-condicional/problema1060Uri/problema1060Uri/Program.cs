using System;
using System.Globalization;

namespace problema1060Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] n = new double[6];
            int i, contador;

            contador = 0;

            for (i = 0; i < 6; i++)
            {
                //Console.Write("", i + 1);
                n[i] = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            foreach(double num in n)
            {
                if(num > 0)
                {
                    contador += 1;
                }

            }

            Console.WriteLine(contador + " valores positivos");

        }
    }
}
