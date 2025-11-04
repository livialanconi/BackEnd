
namespace PrimeiraClasse
{
    public class garrafa
    {
        public int qtdLitros;

        public string marca = "";

        public string modelo = "";

        public string cor = "";

        //métodos
        public void Abrir()
        {
            Console.WriteLine($"Garrafa Abrindo");
        }

        public void Fechar()
        {
            Console.WriteLine($"Garrafa Fechando");
        }

        public void Encher()
        {
            Console.WriteLine($"Garrafa Enchendo");
        }
        
        public void Esvaziar()
        {
            Console.WriteLine($"Garrafa Esvaziando");
        }
    }
}

        