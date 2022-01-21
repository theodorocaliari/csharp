//foreach percorremos todos os elementos de uma coleção

int n = int.Parse(Console.ReadLine());
string[] pessoas = new string[n];

for(int i = 0; i < n; i++)
{
    pessoas[i] = Console.ReadLine();
}

Console.WriteLine("Nomes lidos: ");
foreach(string pessoa in pessoas)
{
    Console.WriteLine(pessoa);
}
