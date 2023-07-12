// Teste 02: Exibir média do Aluno recebendo (x) quantidade de Notas

string nomeAluno;
int qtdProvas;
float nota, soma, media;

qtdProvas = 0;
soma = 0;

Console.WriteLine("Bem-vindo ao Teste 02, para iniciarmos qual é o seu Nome?");
nomeAluno = Console.ReadLine();

while (true)
{
	Console.WriteLine($"{nomeAluno} por favor, nos informe qual foi sua nota na prova?");
	nota = float.Parse(Console.ReadLine());
	qtdProvas++;
	soma += nota;
	media = soma / qtdProvas;

	Console.WriteLine($"Nome: {nomeAluno}");
	Console.WriteLine($"Quantidade de provas: {qtdProvas}");
	Console.WriteLine($"Total de Nota:{soma}");
	Console.WriteLine($"Sua média é de {media}\n");
}