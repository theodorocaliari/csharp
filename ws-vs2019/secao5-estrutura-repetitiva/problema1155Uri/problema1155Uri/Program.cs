// See https://aka.ms/new-console-template for more information
using System.Globalization;

double s;

s = 0;
for (int i = 1; i <= 100; i++)
{
    s += 1 / (double) i;
}

Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));