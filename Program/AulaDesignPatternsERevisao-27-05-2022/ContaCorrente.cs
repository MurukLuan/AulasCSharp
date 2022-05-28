using System;
using System.Collections.Generic;
using System.Text;

namespace AulaDesignPatternsERevisao_27_05_2022
{
    class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
        }

        public ContaCorrente(string titularConta) : base(titularConta)
        {
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor + 10.00;
        }
    }
}
