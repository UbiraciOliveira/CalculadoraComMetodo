using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Engine
{
    internal class Calculos
    {
       // Método de Somar
       public static double Somar(double a, double b)
        {
            return a + b; // O Return devolve o resultado para quem o chamou
        }

        // Método de Subtrair
        public static double Subtrair(double a, double b)
        {
            return a - b;
        }

        // Método de Multiplicar
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método de Dividi
        public static double Dividi(double a, double b) 
        { 
            return a / b; 
        }
    }
}
