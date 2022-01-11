using System;

namespace problema1070Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            //int[] impares = new int[6];

            num = int.Parse(Console.ReadLine());

            for(i = 0; i < 6; i++)
            {
                
                if(num % 2 != 0)
                {
                    //impares[i] = num;
                    Console.WriteLine(num);
                }
                else
                {
                    i--;
                }

                num += 1;
            }

        }
    }
}
