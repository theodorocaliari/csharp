int n = int.Parse(Console.ReadLine());
string[] nomes = new string[n];
int[] idades = new int[n];

string[] valores;

for (int i = 0; i < n; i++)
{
    valores = Console.ReadLine().Split(' ');
    nomes[i] = valores[0];
    idades[i] = int.Parse(valores[1]);
}

int count, key, maior;
key = 0;
maior = 0;
count = 0;

foreach (int idade in idades)
{
    if (maior < idade)
    {
        maior = idade;
        key = count;
    }
    count++;
}

Console.WriteLine($"Pessoa mais velha: {nomes[key]}");