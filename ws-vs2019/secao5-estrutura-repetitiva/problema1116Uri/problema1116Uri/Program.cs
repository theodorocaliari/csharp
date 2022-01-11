using System;
using System.Globalization;

namespace problema1116Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x, y, divisao;

            n = int.Parse(Console.ReadLine());
            
            do
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0],CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if(y != 0)
                {
                    divisao = x / (double)y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
                n--;
            } while (n != 0);
        }
    }
}
