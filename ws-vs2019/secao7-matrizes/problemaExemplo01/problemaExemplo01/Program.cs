int linha, coluna;
int[,] A;

string[] s1 = Console.ReadLine().Split(' ');

linha = int.Parse(s1[0]);
coluna = int.Parse(s1[1]);
A = new int[linha, coluna];

for(int i = 0; i < linha; i++)
{
    string[] s = Console.ReadLine().Split(' '); 
    for(int j = 0; j < coluna; j++)
    {
        A[i, j] = int.Parse(s[j]);
    }
}

for(int i = 0; i < linha; i++)
{
    for(int j = 0; j < coluna; j++)
    {
        Console.Write($"{A[i,j]} ");
    }
    Console.WriteLine();
}
