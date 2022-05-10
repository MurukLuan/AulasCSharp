using System;
using System.Collections.Generic;
using System.Text;

namespace CodigoSExemploAula09_05_2022
{
    class Calculadora
    {

        public static int Somar(params int[] numeros)
        {
            int soma = 0;
            for(int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        public static void Dobrar(int origem, out int resultado)
        {
            resultado = origem * 2;
        }
    }
}
