using System.Globalization;

int quantiaEntradas, countH, countF, count;
quantiaEntradas = int.Parse(Console.ReadLine());

string[] helperVet;
string[] infoVet = new string[quantiaEntradas * 2];
float maior, menor, somatoriaAlturaF;

somatoriaAlturaF = 0;
count = 0;
countH = 0;
countF = 0;
maior = 0;
menor = 0;


for(int i = 0; i < quantiaEntradas; i++)
{
    helperVet = Console.ReadLine().Split(' ');
    infoVet[i+count] = helperVet[0];
    infoVet[(i+count) + 1] = helperVet[1];
    count++;
}


count = 0;
for (int i = 0; i < quantiaEntradas; i++)
{
    if(infoVet[(i+count)+1] == "M")
    {
        countH += 1;
    }
    else
    {
        countF += 1;
        somatoriaAlturaF += float.Parse(infoVet[i+count], CultureInfo.InvariantCulture);
    }

    if(i % 2 == 0)
    {
        if(float.Parse(infoVet[i], CultureInfo.InvariantCulture) > maior)
        {
            menor = maior;
            maior = float.Parse(infoVet[i], CultureInfo.InvariantCulture);
        }
        else if(float.Parse(infoVet[i], CultureInfo.InvariantCulture) < menor)
        {
            menor = float.Parse(infoVet[i], CultureInfo.InvariantCulture);
        }
    }
    count++;
}

Console.WriteLine(
    $"Menor altura = {menor.ToString("F2", CultureInfo.InvariantCulture)}\n" +
    $"Maior altura = {maior.ToString("F2", CultureInfo.InvariantCulture)}\n" +
    $"Media altura mulheres = {(somatoriaAlturaF / countF).ToString("F2", CultureInfo.InvariantCulture)}\n" +
    $"Numero de homens = {countH}"
    );



