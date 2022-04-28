//Fazer um programa para ler um vetor de N números reais.
//Em seguida, mostrar na tela a média aritmética de todos
//elementos.Depois mostrar todos os elementos do vetor que estejam abaixo da média.

using System.Globalization;

int n;
double[] numeros;
double media = 0.0;

n = int.Parse(Console.ReadLine());
numeros = new double[n];

string[] vet = Console.ReadLine().Split(' ');

for(int i = 0; i < n; i++)
{
    numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

double soma = 0;
foreach(double numero in numeros)
{
    soma += numero;
    media = soma / (double) n;
}

Console.WriteLine(media.ToString(CultureInfo.InvariantCulture));

foreach (double numero in numeros)
{
    if (numero < media)
    {
        Console.WriteLine(numero.ToString("F1", CultureInfo.InvariantCulture));
    }
}
