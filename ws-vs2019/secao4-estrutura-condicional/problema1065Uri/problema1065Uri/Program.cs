using System;

namespace problema1065Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, contador;

            contador = 0;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            if(n1 % 2 == 0)
            {
                contador += 1;
            }
            if(n2 % 2 == 0)
            {
                contador += 1;
            }
            if(n3 % 2 == 0)
            {
                contador += 1;
            }
            if(n4 % 2 == 0)
            {
                contador += 1;
            }
            if(n5 % 2 == 0)
            {
                contador += 1;
            }

            Console.WriteLine(contador + " valores pares");
        }
    }
}
