/*Faça um programa que receba 3 números inteiros e imprima na
tela a somatória total dos números


criar um novo projeto chamado exercicio21*/
int n, resultado = 0;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Digite o número:");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}

Console.WriteLine($"Somatoria total: {resultado}");


