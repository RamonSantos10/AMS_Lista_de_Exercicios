int idadeMin = 0;
int idadeMax = 0;
int idadeMed = 0;

Console.Write("Digite a Idade mínima: ");
idadeMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a Idade máxima: ");
idadeMax = Convert.ToInt32(Console.ReadLine());

idadeMed = ((idadeMin + idadeMax) / 2);
Console.WriteLine($"Idade média: {idadeMed}");