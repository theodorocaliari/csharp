// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
    
int n1, n2, i, j, soma, maior, menor, count, index;
List<int> pares = new List<int>();

bool inside = true;

while (inside)
{
    string[] valores;

    valores = Console.ReadLine().Split();

    n1 = int.Parse(valores[0]);
    n2 = int.Parse(valores[1]);

    pares.Add(n1);
    pares.Add(n2);

    if (n1 <= 0 || n2 <= 0)
    {
        inside = false;
    }
    //no while armazeno os pares
}

int[] resultado = pares.ToArray();

//fora do while faco a soma
index = 0;
for (i = 0; i < resultado.Length; i++)
{

    n1 = resultado[index];
    n2 = resultado[index + 1];

    if (n1 > n2)
    {
        maior = n1;
        menor = n2;
    }
    else
    {
        maior = n2;
        menor = n1;
    }

    if(n1 <= 0 || n2 <= 0)
    {
        break;
    }

    soma = 0;
    count = 0;
    for (j = menor; j <= maior; j++)
    {
        soma += j;
        Console.Write($"{j} ");
        count++;
    }

    Console.WriteLine($"Sum={soma}");

    index += 2;
}


int n1, n2, i, j, soma, maior, menor, count, index;
List<int> pares = new List<int>();

bool inside = true;

while (inside)
{
    string[] valores;

    valores = Console.ReadLine().Split();

    n1 = int.Parse(valores[0]);
    n2 = int.Parse(valores[1]);

    pares.Add(n1);
    pares.Add(n2);

    if (n1 <= 0 || n2 <= 0)
    {
        inside = false;
    }
    //no while armazeno os pares
}

int[] resultado = pares.ToArray();

//fora do while faco a soma
index = 0;
for (i = 0; i < resultado.Length; i++)
{

    n1 = resultado[index];
    n2 = resultado[index + 1];

    if (n1 > n2)
    {
        maior = n1;
        menor = n2;
    }
    else
    {
        maior = n2;
        menor = n1;
    }

    if(n1 <= 0 || n2 <= 0)
    {
        break;
    }

    soma = 0;
    count = 0;
    for (j = menor; j <= maior; j++)
    {
        soma += j;
        Console.Write($"{j} ");
        count++;
    }

    Console.WriteLine($"Sum={soma}");

    index += 2;
}