using System.Globalization;

int quantMercadorias, lucroAcima20, lucroAbaixo10, lucroEntre10e20;
string[] helper, nomeProduto;
float[] valorCompra, valorVenda;
float totalCompra, totalVenda, lucro;

quantMercadorias = int.Parse(Console.ReadLine());
nomeProduto = new string[quantMercadorias];
valorCompra = new float[quantMercadorias];
valorVenda = new float[quantMercadorias];

lucro = 0;
totalCompra = 0; 
totalVenda = 0;
lucroAbaixo10 = 0;
lucroAcima20 = 0;
lucroEntre10e20 = 0;

for (int i = 0; i < quantMercadorias; i++)
{
    helper = Console.ReadLine().Split(' ');
    nomeProduto[i] = helper[0];
    valorCompra[i] = float.Parse(helper[1], CultureInfo.InvariantCulture);
    valorVenda[i] = float.Parse(helper[2], CultureInfo.InvariantCulture);

    totalCompra += valorCompra[i];
    totalVenda += valorVenda[i];

    lucro = valorVenda[i] - valorCompra[i];

    double porcentagemLucro = lucro / valorCompra[i] * 100.0;

    if(porcentagemLucro < 10.0)
    {
        lucroAbaixo10++;
    }
    else if(porcentagemLucro <= 20.0 )
    {
        lucroEntre10e20++;
    }
    else
    {
        lucroAcima20++;
    }

}

Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10}\n" +
    $"Lucro entre 10% e 20 %: {lucroEntre10e20}\n" +
    $"Lucro acima de 20%: {lucroAcima20}\n" +
    $"Valor total de compra: {totalCompra.ToString("F2", CultureInfo.InvariantCulture)}\n" +
    $"Valor total de venda: {totalVenda.ToString("F2", CultureInfo.InvariantCulture)}\n" +
    $"Lucro total: {(totalVenda - totalCompra).ToString("F2", CultureInfo.InvariantCulture)}\n");
