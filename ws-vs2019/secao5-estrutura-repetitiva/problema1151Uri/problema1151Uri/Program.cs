// See https://aka.ms/new-console-template for more information

int n, nAnt1, nAnt2, nAtual;
bool passThroghWhile = false;

n = int.Parse(Console.ReadLine());

while (n < 0 || n > 46)
{
    Console.WriteLine("O valor númerico deve ser número positivo menor que 46. Tente novamente.");

    n = int.Parse(Console.ReadLine());

    if (n < 0 || n > 46)
    {
        passThroghWhile = true;
    }
}

if (passThroghWhile)
{
    Console.WriteLine("Número no intervalo correto.\nFibonacci!");
}

nAnt1 = 0;
nAnt2 = 0;

for (int i = 0; i < n; i++)
{
    if (i == 0)
    {
        nAtual = 0;
    }
    else if (i == 1)
    {
        nAtual = 1;
    }
    else
    {
        nAtual = nAnt1 + nAnt2;
    }

    nAnt1 = nAnt2;
    nAnt2 = nAtual;

    if (i != n)
    {
        Console.Write ($"{nAtual} ");
    }
    else
    {
        Console.WriteLine($"{nAtual}");
    }
}