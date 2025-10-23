/*Faça um programa que o usuário informe o salário recebido e o total gasto.
Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.*/

 Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem Vindo, usuario     ");
    Console.WriteLine("----------------------------");
Console.WriteLine("");

 double salario, gastos;

        Console.Write("Digite o salário recebido: R$ ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o total gasto: R$ ");
        gastos = double.Parse(Console.ReadLine());

if (gastos <= salario)
{
    Console.WriteLine("Gastos dentro do orçamento.");
}
else
{
    Console.WriteLine("Orçamento estourado!!");
}
        
