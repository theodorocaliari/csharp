// See https://aka.ms/new-console-template for more information

int n;

//primeiro multiplica pela linha
//depois soma 1 ao resultado de cada valor multiplicado acima

n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} {i * i} {i * i * i}");
    Console.WriteLine($"{i} {(i * i) + 1} {(i * i * i) + 1}" );
}