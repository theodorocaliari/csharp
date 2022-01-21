using System.Globalization;

int n;
double[] vet;
double soma, media;

n = int.Parse(Console.ReadLine());

vet = new double[n];

string[] s = Console.ReadLine().Split(' ');

soma = 0;
media = 0;

for (int i = 0; i < n; i++)
{
    vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
    Console.Write($"{vet[i].ToString("F1", CultureInfo.InvariantCulture)} ");
    soma += vet[i];
}

media = soma / (double) n;

Console.WriteLine();
Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
