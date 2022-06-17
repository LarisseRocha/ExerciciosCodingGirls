using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
     class Calculadora
     {

        public double num1;

        public double num2;

        public double resultado;

        public double multiplicacao()
        {
            resultado = num1 * num2;
            return resultado;
        }

        public double divisao()
        {
            resultado = num1 / num2;
            return resultado;
        }

        public double subtracao()
        {
            resultado = num1 - num2;
            return resultado;
        }


    }
}
