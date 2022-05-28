double v1 = 0;
double v2 = 0;
double total = 0;

Console.Write("Digite o 1º valor: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o 2º valor: ");
v2 = Convert.ToDouble(Console.ReadLine());

total = (v1 - v2);

Console.WriteLine($"({v1}) - ({v2}) = {total}");

if (total > 0)
{
    Console.WriteLine($"TOTAL POSITIVO");
}
else if (total < 0)
{
    Console.WriteLine($"TOTAL NEGATIVO");
}
else
{
    Console.WriteLine($"TOTAL NULO");
}
