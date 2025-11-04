using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome;
        public double N1, N2, N3;

        //Construtor com parametros
        public MediaAluno(double param1, double param2, double param3)
        {
            //Define os valores iniciais para as minhas propriedades
            N1 = param1;
            N1 = param2;
            N3 = param3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0;
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;

            Console.WriteLine($"A média do(a) {Nome} foi {Media} 😊");
        }
    }
}