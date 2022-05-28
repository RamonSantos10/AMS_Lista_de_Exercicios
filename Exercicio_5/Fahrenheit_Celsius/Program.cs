double fahrenheit = 0;
double celsius = 0;

Console.Write("Digite o valor em °F: ");
fahrenheit = Convert.ToDouble(Console.ReadLine());

celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"{fahrenheit}°F = {celsius}°C");