double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double nota4 = 0;
double media = 0;

Console.Write("Digite a 1ª nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a 2ª nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a 3ª nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a 4ª nota: ");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Media: {media}");

if (media > 7)
{
    Console.WriteLine($"ALUNO APROVADO");
}
else{
    Console.WriteLine($"ALUNO REPROVADO");
}
