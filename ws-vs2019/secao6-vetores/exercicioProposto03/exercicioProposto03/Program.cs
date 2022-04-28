// Faça um programa para ler dois vetores A e B, contendo N elementos cada.
// Em seguida, gere um terceiro vetor C onde
// cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.

int n;
int[] vetA, vetB, vetC;

n = int.Parse(Console.ReadLine());

vetA = new int[n];
vetB = new int[n];
vetC = new int[n];

string[] vet1 = Console.ReadLine().Split(' ');
for (int i = 0; i < n; i++)
{
    vetA[i] = int.Parse(vet1[i]);
}

string[] vet2 = Console.ReadLine().Split(' ');
for (int j = 0; j < n; j++)
{
    vetB[j] = int.Parse(vet2[j]);
}

for(int k = 0; k < n; k++)
{
    vetC[k] = vetA[k] + vetB[k];

    if(k != vetC.Length)
    {
        Console.Write($"{vetC[k]} ");
    }
    else
    {
        Console.WriteLine($"{vetC[k]}");
    }
}