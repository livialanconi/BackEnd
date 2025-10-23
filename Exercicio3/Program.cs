/*Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é
quilátero, Isósceles ou Escaleno. Sendo que:     

− Triângulo Equilátero: possui os 3 lados iguais.
− Triângulo Isóscele: possui 2 lados iguais.
− Triângulo Escaleno: possui 3 lados diferentes.*/

 Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem Vindo, usuario     ");
    Console.WriteLine("----------------------------");
Console.WriteLine("");

double lado1, lado2, lado3;

Console.WriteLine("Digite o primeiro lado do triângulo:");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo:");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo:");
lado3 = double.Parse(Console.ReadLine());

if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("As medidas informadas não formam um triângulo.");
}