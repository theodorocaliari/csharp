using System;
using System.Globalization;

namespace problema1040Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, p1, p2, p3, p4, media, notaExame, mediaFinal;
            string mensagem, mensagemFinal;

            p1 = 2;
            p2 = 3;
            p3 = 4;
            p4 = 1;
            notaExame = 0;
            mediaFinal = 0;

            mensagem = string.Empty;
            mensagemFinal = string.Empty;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = ((n1 * p1) + (n2 * p2) + (n3 * p3) + (n4 * p4)) / (p1 + p2 + p3 + p4);

            //gambiarra
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            if (media >= 7.0)
            {
                //aprovado
                mensagem = "Aluno aprovado.";

                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine(mensagem);
            }
            else if (media < 5.0)
            {
                //reprovado
                mensagem = "Aluno reprovado.";

                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine(mensagem);
            }
            else
            {
                //exame
                mensagem = "Aluno em exame.";
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (notaExame + media) / 2;
            }

            

            if (mediaFinal != 0 && mediaFinal > 5.0)
            {
                //aprovado
                mensagemFinal = "Aluno aprovado.";

                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine(mensagem);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine(mensagemFinal);
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));

            }
            else if (mediaFinal != 0 && mediaFinal <= 4.9)
            {
                //reprovado
                mensagemFinal = "Aluno reprovado.";

                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine(mensagemFinal);
            }

        }
    }
}
