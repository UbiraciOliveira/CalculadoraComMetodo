namespace Calculadora.Engine
{
    public static class Calculos
    {
        public static double Somar(double a, double b)
        {
            return a + b;
        }

        // 1. Método de Subtrair
        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        // 2. Método de Multiplicar
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // 3. Método de Dividir com uma proteção simples contra erro
        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero!");
                return 0;
            }
            return a / b;
        }
    }
}
