// See https://aka.ms/new-console-template for more information

using System.Globalization;

int n = int.Parse(Console.ReadLine());
double[] vetor;

vetor = new double[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

for (int j = 0; j < vetor.Length; j++)
{
    Console.WriteLine($"{vetor[j].ToString("F1", CultureInfo.InvariantCulture)}");
}
