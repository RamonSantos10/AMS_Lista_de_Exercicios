double celsius = 0;
double fahrenheit = 0;

Console.Write("Digite o valor em °C: ");
celsius = Convert.ToDouble(Console.ReadLine());

fahrenheit = (9 * celsius + 160) / 5;

Console.WriteLine($"{celsius}°C = {fahrenheit}°F");