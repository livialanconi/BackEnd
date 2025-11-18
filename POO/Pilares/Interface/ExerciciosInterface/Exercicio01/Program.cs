//Exercicio 1
//Crie uma interface chamada IForma com o método CalcularArea.
//Crie duas classes que imlementem essa interface: Retangulo e Circulo.
//No programa, peça os valores necessários e exiba a área calculada para cada forma.

//No retângulo utilizar o cálculo = Largura * Altura;
//No círculo utilizar o cálculo = PI * Raio * Raio;

//Extra: Pesquisar sobre classe Mth do C# e utilizar a constante PI - Math.PI

//Retangulo
using Exercicio01;
Console.Clear();

Console.WriteLine($"=== Bem vindo ao programa Cálculos de Geometria :) ===");
Console.WriteLine();

Console.WriteLine($"Vamos calcular o Retângulo");

//Altura e Largura
Console.WriteLine($"Digite a Largura do Retângulo: ");
float l = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a Altura do Retângulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Agora vamos calcular a área do círcul o");
Console.WriteLine($"Informe o raio do cículo: ");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine($"Fim do programa");
Console.WriteLine();