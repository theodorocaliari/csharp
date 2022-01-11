using System;

namespace problema1114Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            senha = Console.ReadLine();
            while(senha != "2002")
            {
                Console.WriteLine("Senha Invalida");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
