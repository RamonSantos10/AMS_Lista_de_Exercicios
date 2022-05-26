double altura = 0;
double pIdeal = 0;

Console.Write("Digite sua altura em metros: ");
altura = Convert.ToDouble(Console.ReadLine());

pIdeal = ((72.7 * altura) - 58);

Console.WriteLine($"Seu peso ideal é: {pIdeal}Kg");