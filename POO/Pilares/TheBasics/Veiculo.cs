
namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;

        public void Ligar()
        {
            Console.WriteLine($"Ligando o Veículo");
        }
        public void Desligar()
        {
            Console.WriteLine($"Veículo desligado");
        }
    }
}