using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeCalculadora
{
    class Calcular
    {
        public double N1;
        public double N2;
        public string Operador;

        public string Calculadora()
        {
            if(Operador == "+")
            {
                return "" + (N1 + N2);
            }else if( Operador == "*")
            {
                return "" + (N1 * N2);
            }else if(Operador == "-")
            {
                return "" + (N1 - N2);
            }else if( Operador == "/")
            {
                if(N2 == 0)
                {
                    return "O segundo numero não pode ser zero";
                }
                else
                {
                    return "" + (N1 / N2);    
                }
            }
            else
            {
                return "O operador Digitado é inválido!";
            }
        }

        public override string ToString()
        {
            return "Resultado : " + Calculadora();
        }
    }
}
