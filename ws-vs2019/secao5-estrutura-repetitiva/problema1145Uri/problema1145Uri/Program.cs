// See https://aka.ms/new-console-template for more information

int n1, n2, count, i, maior, menor;
string[] valores;

valores = Console.ReadLine().Split(' ');

n1 = int.Parse(valores[0]);
n2 = int.Parse(valores[1]);

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

count = 0;
for (i = 1; i <= maior; i++) {

    count++;
    if (count == menor)
    {
        Console.WriteLine($"{i}");
        count = 0;
    }
    else
    {
        Console.Write($"{i} ");
    }
    
}