using System.Globalization;

int n = int.Parse(Console.ReadLine());
double[] numeros = new double[n];

string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

double maior = 0.0;
int count = 0, posicao = 0;
foreach(double numero in numeros)
{
    if(numero > maior)
    {
        maior = numero;
        posicao = count;
    }
    count++;
}

Console.WriteLine($"Maior Numero: {maior.ToString("F1", CultureInfo.InvariantCulture)}\nPosição: {posicao}");

