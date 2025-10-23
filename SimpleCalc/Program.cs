//Pedir o nome do usuario, pedir dois numeros e mostrar a soma dos numeros no final

string nome;
int numero1;
int numero2;

//pedir os nomes pro usuario
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

//pedir os dois numeros
Console.WriteLine("Digite o primeiro número");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());

//somar os dois numeros
int soma = numero1 + numero2;

Console.WriteLine(nome);
Console.WriteLine(soma);