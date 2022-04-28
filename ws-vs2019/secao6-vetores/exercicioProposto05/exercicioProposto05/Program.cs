using System.Globalization;

int quantia, contador;

quantia = int.Parse(Console.ReadLine());

string[] valoresString = Console.ReadLine().Split(' ');
double[] valoresDouble = new double[quantia];
double soma, media;


for (int i = 0; i < quantia; i++)
{
    valoresDouble[i] = double.Parse(valoresString[i], CultureInfo.InvariantCulture);
    
}

soma = 0.0;
contador = 0;
foreach (double numero in valoresDouble)
{
    if(numero % 2 == 0)
    {
        soma += numero;
        contador++;
    }
}

media = soma / (double) contador;

Console.WriteLine($"A média é: {media.ToString("F2", CultureInfo.InvariantCulture)}");