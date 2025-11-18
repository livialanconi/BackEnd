
namespace TheBasics
{
    public class Professor : Pessoa
    {
        public float Salario;


        //chama o construtor da classe mãe e repasse o endereço 
        public Professor(Endereco endereco) : base(endereco)
        {
            
        }
    }
}