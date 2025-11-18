using System.Reflection.Metadata.Ecma335;
using Exercicio02;

// Cria uma lista de objetos Fatura
List<Imprimivel> documentos = new List<Imprimivel>();

// Fatura fatLivia = new Fatura("Livia", "Izabel Dark Lab", 50, 1);

// fatLivia.Imprimir();

//Criar um menu da seguinte forma
int opcao;
do
{
    Console.Clear();
    Console.WriteLine($"Menu de Opções");
    Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatótio
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair

Escolha a opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 4:
            Console.WriteLine($"Listar Faturas");
            break;
        case 5:
            Console.WriteLine($"Listar Relatórios");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;

    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();
} while (opcao != 0);

//Funções Auxiliares
void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    Console.WriteLine($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    Console.WriteLine($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    Console.Write($"Quantos dias a fatura esta em atraso?");
    int diasAtraso = int.Parse(Console.ReadLine());

    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    documentos.Add(f);

}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do Contratante:");
    string contratante = Console.ReadLine();
    Console.WriteLine($"Digite o nome da empresa contratada:");
    string contratada = Console.ReadLine();

    Console.WriteLine($"Digite as cláusulas do contrato:");
    string txtClausulas = Console.ReadLine();

    Contrato ojbContrato = new Contrato(contratante, contratada, txtClausulas);
    documentos.Add(ojbContrato);
}

void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome responsável pelo relatório:");
    string resp = Console.ReadLine();

    Console.WriteLine($"Digite o texto do relatório:");
    string txt = Console.ReadLine();

    Relatorio relatorio = new Relatorio(resp, txt);
    documentos.Add(relatorio);

    Console.WriteLine($"Relatório cadastrado com sucesso");
}

void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarContratos()
{
    Console.WriteLine($"Listando os Contratos: ");
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
     Console.WriteLine($"Listando os Relatórios: ");
    foreach (var item in documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}