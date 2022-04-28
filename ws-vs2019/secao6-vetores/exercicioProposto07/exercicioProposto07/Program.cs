using System.Globalization;

int quantiaAlunos, contador;
quantiaAlunos = int.Parse(Console.ReadLine());

string[] helperVet;
string[] nomeAluno = new string[quantiaAlunos];
double[] notaAluno = new double[quantiaAlunos * 2];
double[] mediaAluno = new double[quantiaAlunos];


contador = 0;
for (int i = 0; i < quantiaAlunos; i++)
{
    helperVet = Console.ReadLine().Split(' ');

    nomeAluno[i] = helperVet[0];
    notaAluno[i + contador] = double.Parse(helperVet[1], CultureInfo.InvariantCulture);
    notaAluno[(i + contador) + 1] = double.Parse(helperVet[2], CultureInfo.InvariantCulture);
    contador++;
}

contador = 0;
for (int j = 0; j < quantiaAlunos; j++)
{
    for (int k = 0; k < 1; k++)
    {
        mediaAluno[j] = (notaAluno[contador + j] + notaAluno[(contador + j) + 1]) / 2.0;
    }
    contador++;
}

Console.WriteLine("Alunos Aprovados:");
contador = 0;
foreach (string aluno in nomeAluno)
{
    if (mediaAluno[contador] >= 6.0)
    {
        Console.WriteLine(aluno);
    }
    contador++;
}