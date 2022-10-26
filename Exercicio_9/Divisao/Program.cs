double valor1 = 0;
double valor2 = 0;
double total = 0;
double resto = 0;

Console.Write("Digite o 1º valor: ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o 2º valor: ");
v2 = Convert.ToDouble(Console.ReadLine());

total = (valor1 / valor2);
resto = (valor1 % valor2);

if (valor2 == 0)
{
    Console.WriteLine($"IMPOSSÍVEL DIVIDIR POR 0");
}
else
{
    Console.WriteLine($"({valor1}) / ({valor2})");
    Console.WriteLine($"TOTAL: {total}");
    Console.WriteLine($"RESTO: {resto}");
}
