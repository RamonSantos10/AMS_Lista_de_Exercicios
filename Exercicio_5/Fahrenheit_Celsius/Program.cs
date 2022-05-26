int fahrenheit = 0;
int celsius = 0;

Console.Write("Digite o valor em °F: ");
fahrenheit = Convert.ToInt32(Console.ReadLine());

celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"{fahrenheit}°F = {celsius}°C");