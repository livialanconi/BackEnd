/*Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time)
e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.*/

 Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem Vindo, usuario     ");
    Console.WriteLine("----------------------------");
Console.WriteLine("");

int golsTime1, golsTime2;

        Console.Write("Digite o número de gols do primeiro time: ");
        golsTime1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de gols do segundo time: ");
        golsTime2 = int.Parse(Console.ReadLine());

if (golsTime1 > golsTime2)
{
    Console.WriteLine("Vitória do primeiro time!");
}
else if (golsTime2 > golsTime1)
{
    Console.WriteLine("Vitória do segundo time!");
}
else
{
    Console.WriteLine("O jogo terminou empatado!");
}
        