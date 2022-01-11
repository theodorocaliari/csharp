using System;
using System.Globalization;

namespace problema1045Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, x, y, z;
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            x = 0.0;
            y = 0.0;
            z = 0.0;

            if (B > A && B > C)
            {
                x = B;
                if (A > C)
                {
                    y = A;
                    z = C;
                }
                else
                {
                    y = C;
                    z = A;
                }
            }
            else if (C > A && C > B)
            {
                x = C;
                if (A > B)
                {
                    y = A;
                    z = B;
                }
                else
                {
                    y = B;
                    z = A;
                }
            }
            else
            {
                x = A;
                y = B;
                z = C;
            }

            A = x;
            B = y;
            C = z;

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }

                if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == C && A == B && C == B)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (B == C || A == C || A == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
