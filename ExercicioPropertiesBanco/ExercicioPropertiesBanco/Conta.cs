using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropertiesBanco
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta()
        {
        }

        public Conta(int numeroConta, int agencia, string nome)
        {
            NumeroConta = numeroConta;
            Agencia = agencia;
            Nome = nome;
        }

        public void Sacar(double valor)
        {
            Saldo = valor - Saldo;
        }

        public void Depositar(double valor)
        {
            Saldo = valor + Saldo;
        }

    }
}
