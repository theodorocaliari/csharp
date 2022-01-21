int n;
n = int.Parse(Console.ReadLine());
int[] vetor = new int[n];

string[] s = Console.ReadLine().Split(' ');

for (int i = 0; i < n; i++)
{
    vetor[i] = int.Parse(s[i]);
}

for(int i = 0; i < n; i++)
{
    if (vetor[i] < 0)
    {
        Console.WriteLine(vetor[i]);
    }
}
