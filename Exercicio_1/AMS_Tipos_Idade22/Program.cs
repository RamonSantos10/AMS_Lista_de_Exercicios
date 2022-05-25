int idadeMin = 0;
int idadeMax = 0;
int idadeMed = 0;

Console.Write("Digite a Idade Mínima: ");
idadeMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a Idade Máxima: ");
idadeMax = Convert.ToInt32(Console.ReadLine());

idadeMed = ((idadeMin + idadeMax) / 2);
Console.WriteLine($"Idade Média: {idadeMed}");