using System;

namespace problema1142Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, vezes;

            n = int.Parse(Console.ReadLine());

            vezes = 1;
            for(i=1; vezes <= n; i++)
            {
                
                if (i % 4 == 0)
                {
                    Console.WriteLine("PUM");
                    vezes++;
                }
                else
                {
                    Console.Write($"{i} ");
                    
                }
            }
        }
    }
}
