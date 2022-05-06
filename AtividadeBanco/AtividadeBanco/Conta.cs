using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeBanco
{
    class Conta
    {
        private int Idade;
        public string Nome { get; set; }     
        public double Saldo;
        public int NumeroConta;

        /*
         * Uma forma de se declarar get e set quando se tem uma regra 
         * de negocio
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
            }
        }*/
        /*
         * exemplo de implementação dos metodos get e set "padrã java"
                public string GetNome()
                {
                    return _nome;
                }

                public string SetNome(string nome)
                {
                   return _nome = nome;
                }
        */
        public void Saque(double saque)
        {
            if (Saldo >= saque)
            {
                Saldo = Saldo - saque;
            }
            else
            {
                Console.WriteLine("Valor de saque não permitido, sem saldo!");
            }
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
    }
}
