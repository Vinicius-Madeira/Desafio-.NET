// Teste 03: Exibir média de cada aluno

string nomeAluno, status;
float nota1, nota2, media;

Console.WriteLine("Bem-vindo ao Teste 03");

while (true)
{
	Console.WriteLine("Informe o nome do Aluno:");
	nomeAluno = Console.ReadLine();

	Console.WriteLine($"Qual foi a nota do primeiro Semestre do aluno {nomeAluno}?");
	nota1 = float.Parse(Console.ReadLine());
	Console.WriteLine($"Qual foi a nota do segundo Semestre do aluno {nomeAluno}?");
	nota2 = float.Parse(Console.ReadLine());

	media = (nota1 + nota2) / 2;

	Console.WriteLine($"Nome do aluno: {nomeAluno}");
	Console.WriteLine($"Média:{media}");

	status = media >= 6 ? "Aprovado" : "Reprovado";
	Console.WriteLine($"O Aluno foi:{status}\n");
}