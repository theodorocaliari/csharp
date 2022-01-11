// See https://aka.ms/new-console-template for more information

int n, x, y, i, j, soma, menor, maior;


n = int.Parse(Console.ReadLine());

i = 0;
while(i != n)
{
    string[] numbers = Console.ReadLine().Split(' ');

    x = int.Parse(numbers[0]);
    y = int.Parse(numbers[1]);

    if(x < y)
    {
        menor = x;
        maior = y;
    }
    else
    {
        menor = y;
        maior = x;
    }

    soma = 0;
    for(j = menor; j < maior; j++)
    {
        if(j != menor && j % 2 != 0)
        {
            soma += j;
        }
    }
    Console.WriteLine(soma);
    i++;
}