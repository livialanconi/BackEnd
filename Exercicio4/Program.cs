/*Escreva um programa que verifique a validade de uma senha fornecida pelo usuário.
A senha válida é o número 1234. Devem ser impressas as seguintes mensagens:
- ACESSO PERMITIDO caso a senha seja válida.
- ACESSO NEGADO caso a senha seja inválida*/

 Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem Vindo, usuario     ");
    Console.WriteLine("----------------------------");
Console.WriteLine("");

Console.Write("Digite a senha: ");
        int senha = int.Parse(Console.ReadLine());

        if (senha == 1234)
            Console.WriteLine("ACESSO PERMITIDO");
        else
            Console.WriteLine("ACESSO NEGADO");