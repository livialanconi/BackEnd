using System.Diagnostics.Tracing;

Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Digite seu sobrenome:");
string sobrenomenome = Console.ReadLine();

Console.WriteLine($"Ok, {nome}! Agora vamos dar as boas vindas a você!");

Console.WriteLine($"Por favor escolha uma opção abaixo:");
Console.WriteLine($"1- Saudar com nome"); //receba o nome por parâmetro e escrever a saudação dentro da função
Console.WriteLine($"2- Saudar com sobrenome"); //receba o sobrenome por parâmetro e escrever a saudação dentro da função
Console.WriteLine($"3- Saudar com nome completo"); //receba o nome e sobrenome devolve o nome completo do usuério
Console.WriteLine($"0- Apenas saudação genérica"); //só devolve um texto de saudação genérico

int opcao = 0;
switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudarComNome(nome);
        break;
    case 2:
        SaudacomSobrenome (sobrenomenome)
    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja vem vindo {nomeCompleto}");
        break;
        default;
        break;
}

//função que escreve uma saudação de forma genérica
void SaudacaoGenerica()
{
    Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia!");
}

//recebe um nome e escreve uma saudação personalizada
void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem vindo, {nomeRecebido}");
}

//recebe dois parametros e devolve um texto - recebe nome e sobrenome e devolve o nome completo
string DevolveNomeCompleto(string nomeRecebido, string sobrenomeRecebido)
{
    return nomeRecebido + " " + sobrenomeRecebido;
} 