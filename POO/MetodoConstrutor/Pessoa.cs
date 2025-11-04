using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //metodo construtor de Pessoa, possuindo parametros

        //parametros representam valores para suas respectivas 
        //propriedades ou seja, estamos inicializando valores para
        //as propriedades nome e idade

        public Pessoa(string n, int i)
        {
            Nome = n; //inicializa com o valor de n
            Idade = i; //inicializa com o valor de i
        } 
        
        public void ExibirDados()
        {

            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}