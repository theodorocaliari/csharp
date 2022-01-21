int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
string[] vet = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(vet[i]);
}

int count = 0;
foreach(int numero in numeros)
{
    if(numero % 2 == 0) {
        Console.Write($"{numero} ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);