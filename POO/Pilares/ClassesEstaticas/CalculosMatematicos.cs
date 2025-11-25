
namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        //Operções Matemáticas Simples
        //visibilidade tipoDeRetorno Nome(parâmetros){corpo}

        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtrair (float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static float Dividir (float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine($"Divisão Inválida");
                return 0;
            }

            return a / b;
        }
        

    }
}