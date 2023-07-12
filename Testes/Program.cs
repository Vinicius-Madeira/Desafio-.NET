// Teste 01: Exibir média do Aluno

float nota_1, nota_2, media;

Console.WriteLine("Digite a nota do primeiro semestre:");
nota_1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do segundo semestre:");
nota_2 = float.Parse(Console.ReadLine());

media = (nota_1 + nota_2) / 2;

Console.WriteLine($"Sua média é de {media}");