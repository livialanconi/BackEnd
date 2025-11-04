namespace PrimeiraClasse
{
    public class Hello
    {
        public string TextoHello = "";

        public void SaldarUsuario(string n)
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }
}