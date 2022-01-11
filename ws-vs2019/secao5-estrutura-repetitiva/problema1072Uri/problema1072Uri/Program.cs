using System;

namespace problema1072Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n2, quantia, dentro, fora;

            n = int.Parse(Console.ReadLine());

            quantia = 0;
            dentro = 0;
            fora = 0;

            if(n < 10000)
            {
                quantia = n;
                do {
                    n2 = int.Parse(Console.ReadLine());
                    if (n2 >= 10)
                    {
                        if (n2 <= 20)
                        {
                            dentro += 1;
                        }
                        else
                        {
                            fora += 1;
                        }
                    }
                    else
                    {
                        fora += 1;
                    }

                    quantia--;
                } while (quantia != 0);

                Console.WriteLine($"{dentro} in");
                Console.WriteLine($"{fora} out");
            }



        }
    }
}
