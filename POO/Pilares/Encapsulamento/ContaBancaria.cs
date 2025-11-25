
namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

    //Construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            Saldo = saldoInicial;
        if (saldoInicial > 0)
                {
                Saldo = saldoInicial;
            }
        }

        public void Depositar(float valor)
        {
            if (valor >= 0)
                {
                    Saldo = valor;
                    return;
                    }

            Console.WriteLine($"Valor para depósito inválido");
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void Saque (float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque efetuado com sucesso!");
                return;
            }

            Console.WriteLine($"Valor para saque inválido");
        }
    }
}