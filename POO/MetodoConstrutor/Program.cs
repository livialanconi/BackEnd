using MetodoConstrutor;

//livia é uma variável do tipo pessoa
// Pessoa livia = new Pessoa("Livia", 16);

// livia.Nome = "Livia Caires";
// livia.Idade = 17;

// Console.WriteLine(@$"O objeto pessoa que criei é o {livia.Nome}
// com a idade {livia.Idade}");

// // livia.Nome = "Amy Lee";

// // livia.Nome = "James";
// livia.ExibirDados();

// Console.WriteLine($"{livia.Nome}");

//primeiro metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();

Console.WriteLine(@$"Primeira Pessoa cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Nome: {PrimeiraPessoa.Idade}
                
");

//segundo metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Pedro Enzo");

Console.WriteLine(@$"Segunda Pessoa cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Nome: {SegundaPessoa.Idade}
                
");


//atividade: peça o nome e a idade da terceira pessoa pelo terminal 
//atribui os valores digitados ao objeto TerceiraPessoa

//terceiro metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Henrique", 16);
System.Console.WriteLine("Digite seu nome:");
TerceiraPessoa.Nome = Console.ReadLine();
System.Console.WriteLine("Digite sua idade:");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Terceira Pessoa cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Nome: {TerceiraPessoa.Idade}  
");

Console.WriteLine("Digite");