int n = int.Parse(Console.ReadLine());
int[,] matriz;
int contador;

matriz = new int[n,n];

for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    for (int j = 0; j < n; j++)
    {
        matriz[i, j] = int.Parse(s[j]);
    }
}

contador = 0;
Console.Write ("Diagonal Principal: ");
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        if(i == j)
        {
            Console.Write($"{matriz[i, j]} ");
        }
        if(matriz[i, j] < 0)
        {
            contador += 1;
        }
    }  
}
Console.WriteLine();

Console.WriteLine($"Quantidade de Negativos: {contador}");
