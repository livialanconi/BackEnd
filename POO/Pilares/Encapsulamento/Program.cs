// using Encapsulamento;
// using Microsoft.Win32.SafeHandles;

// namespace Encapsulamento
// {
//     public static void Main()
//     0
// }

// float dinheiro = -200;

// ContaBancaria contaLiv = new ContaBancaria();
// ContaBancaria contaAmy = new ContaBancaria();

// contaLiv.Depositar(dinheiro);

// Console.WriteLine($"Saldo da Livia R${contaLiv.GetSaldo()}");
// Console.WriteLine($"Saldo da Amy R${contaAmy.GetSaldo()}");

// contaLiv.Saque(100);
// Console.WriteLine($"Saldo após saque da Livia: R${contaLiv.GetSaldo()}");

using Encapsulamento;

Console.Clear();
Carro fusca = new Carro();

fusca.DefinirMarca("Volkswagen");
fusca.DefinirModelo("Fusca 89");

fusca.Acelera(100);
fusca.Acelera(50);

fusca.Frear(10);

Console.WriteLine($"Marca: {fusca.ObterMarca()}");
Console.WriteLine($"Modelo: {fusca.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {fusca.ObterVelocidade()}");