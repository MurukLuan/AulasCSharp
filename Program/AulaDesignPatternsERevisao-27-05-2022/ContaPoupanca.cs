using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDesignPatternsERevisao_27_05_2022
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(string titularConta) : base(titularConta)
        {
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
