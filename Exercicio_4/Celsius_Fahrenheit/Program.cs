int celsius = 0;
int fahrenheit = 0;

Console.Write("Digite o valor de °C: ");
celsius = Convert.ToInt32(Console.ReadLine());

fahrenheit = ((9 * celsius + 160) / 5);

Console.WriteLine($"{celsius}°C = {fahrenheit}°F");