int n1, n2;

Console.WriteLine("Digite o primeiro número");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro número é o maior: {n1}");

}

else if (n1 < n2)
{
    Console.WriteLine($"O segundo número é o maior: {n2}");
}

else
{
    Console.WriteLine($"Os dois números são iguais: {n1} e {n2} são iguais");
}