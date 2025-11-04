//arrays

string[] nomes = new string [4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;

// nomes[0] = "Amy Lee";
// idades[0] = 20;

// nomes[1] = "Eloysa";
// idades[1] = 16;

// nomes[2] = "Pedro Enzo";
// idades[2] = 17;

// nomes[3] = "Henrique";
// idades[1] = 17;

// nomes[4] = "James";
// idades[4] = 17;

do
{
    Console.Clear();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar Alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Precisso <Enter> para encerrar ...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"oção inválida, pressione <Enter> para continuar ...");
            Console.ReadLine();
            break;
    }

} while (opcao != 0);

//FUNÇÕES//

void CadastrarAluno()
{
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar");
        Console.ReadLine();
        return;
    }

    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade do {n}");
    int i = int.Parse(Console.ReadLine());

    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();

}

void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: ");
}

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($" Nome:  {nomes[i]}");
    Console.WriteLine($"Idade: {idades[i]}");
    Console.WriteLine();
}

Console.WriteLine($"Pressione <Enter> para continuar");
Console.ReadLine();