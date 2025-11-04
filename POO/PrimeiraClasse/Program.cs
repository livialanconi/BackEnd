using PrimeiraClasse;

// string nome = "Livia Caires";

// Hello cumprimento = new Hello();

// cumprimento.TextoHello = "Olá usuário";

// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome("Livia Caires");

Carro c1 = new Carro();
c1.marca = "Lamborghini";
c1.modelo = "Urus";
c1.cor = "Preto";
c1.qtdPortas = 4;
c1.qtdRodas = 4;
c1.Ligar();
c1.Acelerar();
c1.Frear();
c1.Desligar();

Carro c2 = new Carro();
c2.marca = "Chevrolet";
c2.modelo = "Camaro";
c2.cor = "Amarelo";
c2.qtdPortas = 2;
c2.qtdRodas = 4;

Console.WriteLine($"Ligando o {c2.modelo}");
Console.WriteLine($"Acelerando o {c2.modelo}");
Console.WriteLine($"Freando o {c2.modelo}");
Console.WriteLine($"Desligando o {c2.modelo}");

Console.WriteLine();
Console.WriteLine($"Características");
Console.WriteLine();

Console.WriteLine($"----- {c1.marca} -----");
Console.WriteLine($"Carro: {c1.marca}");
Console.WriteLine($"Modelo: {c1.modelo}");
Console.WriteLine($"Cor: {c1.cor}");
Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
Console.WriteLine();
Console.WriteLine($"---");
Console.WriteLine();

Console.WriteLine($"----- {c2.marca} -----");
Console.WriteLine($"Carro: {c2.marca}");
Console.WriteLine($"Modelo: {c2.modelo}");
Console.WriteLine($"Cor: {c2.cor}");
Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
Console.WriteLine();

// Criar uma classe que represente uma moto
// pelo menos 4 propriedades
// pelo menos 3 métodos
// na classe program, instanciar 2 objetos moto e exibir
// as propriedades e rodar os métodos igual fizemos com
// a classe carro.

// moto hornetCarburada = new moto();
// moto BMW1200 = new moto();

// hornetCarburada.Marca = "Honda";
// hornetCarburada.Modelo = "Hotnet Carburada";
// hornetCarburada.Acelerar();

// BMW1200.Marca = "BMW";
// BMW1200.Modelo = "1200";
// BMW1200.Acelerar();

//criar uma classe para representar uma garrafa
//propriedades
//métodos

