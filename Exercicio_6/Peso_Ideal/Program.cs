double altura = 0;
double pIdeal = 0;

Console.Write("Digite sua altura em metros: ");
altura = Convert.ToDouble(Console.ReadLine());

pIdeal = ((72.7 * altura) - 58);

Console.WriteLine($"O peso ideal para sua altura é: {pIdeal}Kg");