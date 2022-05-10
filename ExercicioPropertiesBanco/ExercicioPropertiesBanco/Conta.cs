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

        public double Sacar(double valor)
        {
            return Saldo = Saldo - valor;
        }

        public double Depositar(double valor)
        {
            return Saldo = Saldo + valor;
        }

        public override string ToString()
        {
            return "Titular da conta: " + Nome
                + "\nAgencia: " + Agencia
                + "\nConta: " + NumeroConta
                + "\nSaldo: " + Saldo.ToString("F2");
        }

    }
}
