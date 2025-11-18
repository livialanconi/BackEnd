
namespace Exercicio02
{
    public class Fatura : Imprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        public Fatura( string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }

        public void Imprimir()
        {
            CalcularValorDivida();

Console.WriteLine($@"
Credor: {Credor}
Devedor: {Devedor}
Dias de atraso: {Devedor} dia(s)
Valor: R${Valor : F2}
Juros: R${(Juros * DiasDeAtraso) : F2}
Total com Juros: {Valor : F2}
");

            Console.WriteLine($"Credor: {Credor}...");
            Console.WriteLine($"Devedor: {Credor}...");
            Console.WriteLine($"Dias de atraso: {DiasDeAtraso}...");

        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;     
            }
            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}