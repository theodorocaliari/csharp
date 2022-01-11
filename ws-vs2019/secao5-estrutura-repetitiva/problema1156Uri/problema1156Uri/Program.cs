// See https://aka.ms/new-console-template for more information

using System.Globalization;

double a, b, c, s;

s = 0;
b = 1;

for (a = 1; a <= 39; a += 2)
{
    c = a / b;
    s += c;
    b *= 2;
}

Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

