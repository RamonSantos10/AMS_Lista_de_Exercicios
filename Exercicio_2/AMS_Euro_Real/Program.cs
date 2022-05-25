double euro = 0;
double real = 0;

Console.Write("Digite o valor: R$");
real = Convert.ToDouble(Console.ReadLine());

euro = 5.13 *(real);

Console.Write($"R${real} = {euro} euros");