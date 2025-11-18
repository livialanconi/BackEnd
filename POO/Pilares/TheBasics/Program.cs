
using TheBasics;
Console.Clear();

// //array/lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecolivia = new Endereco();
// enderecolivia.Logradouro = "Rua Niterói";
// Pessoa livia = new Pessoa(enderecolivia);
// livia.Nome = "Livia Caires";
// livia.Idade = 16;

// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua lá de casa";
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia Vitória";
// alexia.Idade = 24;

// //guardando os dados na lista

// peoples.Add(livia);
// peoples.Add(alexia);

// foreach (Pessoa p in peoples)
// {
//     Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endLuis = new Endereco();
// endLuis.Logradouro = "Spínola Teixeira";
// endLuis.Numero = 3960;

// Aluno luisFernando = new Aluno(endLuis);
// luisFernando.Nome = "Luis Fernando";
// luisFernando.Curso = "Desenvolvimento de Sistemas";
// luisFernando.RA = "1234-xpto";
// luisFernando.NotaFinal = 9.75f;

// Endereco endProfAlexia = new Endereco();
// endProfAlexia.Logradouro = "Rua lá de casa";
// endProfAlexia.Numero = 987;

// Professor profAlexia = new Professor(endProfAlexia);
// profAlexia.Nome = "Aléxia Vitória";

// Console.WriteLine($"Aluno {luisFernando.Nome} estuda na turma {luisFernando.Curso} da profa. {profAlexia.Nome}");


Carro fusca = new Carro();
fusca.Marca = "Wolksvagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar 400";

fusca.Ligar();
fusca.AbrirPortaMala();

dominar400.Ligar();
dominar400.Empinar();

Aviao AirbusA220 = new Aviao();
AirbusA220.Marca = "Bombardier";
AirbusA220.Modelo = "AirbusA220";

AirbusA220.Ligar();
AirbusA220.Turbinas();


/*
    CRIAR UMA CLASSE AVIÃO COM 1 PROPRIEDADE E UM MÉTODO QUE SEJAM
    ESPECÍFICOS DE UM AVIÃO.

    CRIE E UTILIZE UMA VARIÁVEL NA PROGRAM.CS E ADICIONE A MARCA,
    MODELO, QUANTIDADE DE RODAS E A PROPRIEDADE ESPECÍFICA DO AVIÃO,
    ALÉM, DE CHAMAR OS MÉTODOS LIGAR E TAMBÉM O MÉTODO QUE VOCÊ CRIOU
    NA CLASSE AVIÃO
*/

