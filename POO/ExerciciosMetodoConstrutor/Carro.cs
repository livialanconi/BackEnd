//Crie uma classe Carro com os atributos marca, modelo e ano.
//Faça um construtor que receba esses três valores e exiba os dados do carro.

namespace ExerciciosMetodoConstrutor
{
    //atributos
    public class Carro
    {
        public string Marca;

        public string Modelo;

        public int Ano;

        //construtor
        public Carro(string ma, string mo, int a)
        {
            Modelo = mo;
            Marca = ma;
            Ano = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}