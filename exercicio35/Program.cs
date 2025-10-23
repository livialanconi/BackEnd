/*Faça um programa que solicite ao usuário um número de repetições "x".
Para cada repetição solicite dois números e imprima qual é o maior deles.*/

using System.Runtime.Intrinsics.X86;

int n = 0, contador;

Console.WriteLine("Digite o número de repetição");
n = int.Parse(Console.ReadLine());

while (contador < n)
{
    Console.WriteLine("Digite o primeiro número:");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número:");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O número {n1} e maior que o número {n2}");

    }
    else if (n1 < n2)
    {
        Console.WriteLine($"O número {n2} e maior que o número {n1}");

    } else

        {
        Console.WriteLine($"Os dois números são iguais: {n1} = {n2}");
    }
        contador++;
}
