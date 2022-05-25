double comissao = 0;
double vendas = 0;

Console.Write("Digite o valor total de vendas desse mês: R$");
vendas = Convert.ToDouble(Console.ReadLine());

comissao = (vendas * 0.05);
Console.Write($"O valor de comissão a ser recebido é de R${comissao} ");