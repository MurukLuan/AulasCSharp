using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoAlgoritmos
{
    class Teste
    {
        public double N1;
        public double N2;
        public string Operador;

        public double Calcular()
        {
            if(Operador == "*")
            {
                return N1 * N2;

            }else if(Operador == "-")
            {
                return N1 - N2;

            }else if(Operador == "/")
            {
                return N1 / N2;
            }
            else if(Operador == "+")
            {
                return N1 + N2;
            }
            else
            {
                return 0.0;
            }
        }

    }
}
