// See https://aka.ms/new-console-template for more information

int n1, n2, i, soma, somaFinal;

n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

while(n2 <= 0)
{
    n2 = int.Parse(Console.ReadLine());
}

soma = 0;
for (i = n2; i <= n1 - 1; i++)
{
    soma += i;
}

somaFinal = n1 + soma;

Console.WriteLine(somaFinal);