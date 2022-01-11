// See https://aka.ms/new-console-template for more information

int n, i;

n = int.Parse(Console.ReadLine());

for(i = 1; i <= n; i++)
{
    if(n % i == 0)
    {
        Console.WriteLine(i);
    }
}