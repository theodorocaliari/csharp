using System;
using System.Globalization;

namespace problema1079Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double n1, n2, n3, p1, p2, p3, media;
            string[] vet = new string[3];

            p1 = 2.0;
            p2 = 3.0;
            p3 = 5.0;

            n = int.Parse(Console.ReadLine());

            do
            {
                vet = Console.ReadLine().Split(' ');

                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

                n--;
            } while (n != 0);

        }
    }
}
