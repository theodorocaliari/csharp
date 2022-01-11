// See https://aka.ms/new-console-template for more information

int n, n1, n2, fatorial;

n = int.Parse(Console.ReadLine());

fatorial = 0;

if(n == 0 || n == 1)
{
    fatorial = 1;
}
else
{
    for (int i = 1; i < n; i++)
    {
        n1 = n;
        n2 = n - i;

        if (i == 1)
        {
            fatorial = n1 * n2;
        }
        else
        {
            fatorial = fatorial * n2;
        }

    }
}

Console.WriteLine(fatorial);