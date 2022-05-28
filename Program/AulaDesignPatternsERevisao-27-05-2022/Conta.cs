using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDesignPatternsERevisao_27_05_2022
{
    class Conta
    {
        public string TitulaConta { get; set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }
        public Conta(string titularConta)
        {
            TitulaConta = titularConta;
        }


        public virtual void Sacar(double valor)
        {
            Saldo -= valor + 2;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

    }
}
