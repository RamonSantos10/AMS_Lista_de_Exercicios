double v1 = 0;
double v2 = 0;
double total = 0;
double resto = 0;

Console.Write("Digite o 1º valor: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o 2º valor: ");
v2 = Convert.ToDouble(Console.ReadLine());

total = (v1 / v2);
resto = (v1 % v2);

if (v1 == 0 || v2 == 0)
{
    Console.WriteLine($"IMPOSSÍVEL DIVIDIR POR 0");
}
else
{
    Console.WriteLine($"({v1}) / ({v2})");
    Console.WriteLine($"TOTAL: {total}");
    Console.WriteLine($"RESTO: {resto}");
}
