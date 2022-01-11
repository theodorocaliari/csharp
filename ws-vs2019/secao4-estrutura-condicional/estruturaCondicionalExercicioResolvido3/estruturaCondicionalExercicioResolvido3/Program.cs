using System;

namespace estruturaCondicionalExercicioResolvido3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            Console.Write("MENOR = ");

            if(a < b && a < c)
            {
                Console.WriteLine(a);
            }else if (b<c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            

        }
    }
}
