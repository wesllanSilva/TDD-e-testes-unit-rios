using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public CalculadoraImp()
        {
        }
        public int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int Subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int Dividir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}