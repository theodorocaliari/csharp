using System.Globalization;

int n;
string[] nomesPessoas;
int[] idadesPessoas;
double[] alturaPessoas;

string[] vet;

n = int.Parse(Console.ReadLine());

nomesPessoas = new string[n];
idadesPessoas = new int[n];
alturaPessoas = new double[n];

//leitura dos dados
for (int i = 0; i < n; i++)
{
    vet = Console.ReadLine().Split(' ');

    nomesPessoas[i] = vet[0];
    idadesPessoas[i] = int.Parse(vet[1]);
    alturaPessoas[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);

}

//calculo da altura media das pessoas
double soma = 0.0;
for(int i = 0; i < n; i++)
{
    soma += alturaPessoas[i];
}

double media = soma / n;
Console.WriteLine($"Altura média: {media.ToString("F2", CultureInfo.InvariantCulture)}");

//porcentagem de pessoas abaixo de 16 anos

int count =0;   
for(int i = 0; i < n; i++)
{
    if(idadesPessoas[i] < 16) { count++; }
}
double porcentagem = (double)count / n * 100.0;
Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagem.ToString("F1", CultureInfo.InvariantCulture)} %");