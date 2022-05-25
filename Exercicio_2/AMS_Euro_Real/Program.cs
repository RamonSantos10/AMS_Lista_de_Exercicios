double euro = 0;
double real = 0;

Console.Write("Digite o valor em euros: ");
euro = Convert.ToDouble(Console.ReadLine());

real = 5.13 *(euro);

Console.Write($"{euro} euros = R${real}");