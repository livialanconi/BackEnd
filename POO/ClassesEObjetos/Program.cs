// using ClassesEObjetos;

// Pessoa livia = new Pessoa();

// livia.Nome = "Livia Caires";
// Console.WriteLine($"{livia.Nome} tem {livia.Idade} anos");


// int novaIdade =  livia.Envelhecer(17);
// Console.WriteLine($"{livia.Nome} tem {livia.Idade} anos");

// novaIdade = livia.Envelhecer(-50);
// Console.WriteLine($"{livia.Nome} tem {livia.Idade} anos");

using ClassesEObjetos;

Console.WriteLine("-- Agência Bancária --");
Console.Write("Digite o nome do titular da conta: ");
string nomeT = Console.ReadLine();

AgenciaBancaria conta = new AgenciaBancaria(nomeT);

Console.WriteLine();
Console.WriteLine($"Seja bem-vindo(a), {conta.Titular}!");
Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}");
Console.WriteLine();

// Loop do menu principal
int opcao = 0;
do
{
    Console.WriteLine("\n--- Menu ---");
    Console.WriteLine("1. Depositar");
    Console.WriteLine("2. Sacar");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o valor do depósito: R$ ");
            double deposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(deposito);
            break;

        case 2:
            Console.Write("Digite o valor do saque: R$ ");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(saque);
            break;

        case 0:
            Console.WriteLine("Encerrando...");
            break;

        default:
            Console.WriteLine("Opção inválida! Escolha uma das opções acima.");
            break;
    }

} while (opcao != 0);