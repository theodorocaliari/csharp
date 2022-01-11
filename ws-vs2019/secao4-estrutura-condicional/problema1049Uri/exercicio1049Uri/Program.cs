using System;

namespace exercicio1049Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra1, palavra2, palavra3;

            palavra1 = Console.ReadLine();
            palavra2 = Console.ReadLine();
            palavra3 = Console.ReadLine();

            if(palavra1 == "vertebrado")
            {
                if(palavra2 == "ave")
                {
                    if (palavra3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if(palavra2 == "inseto")
                {
                    if(palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if(palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
